﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;
using TicketApp.Services.Helpers;
using TicketApp.Services.Login;
using TicketApp.Services.Solicitudes;
using TicketApp.Signal;
using static TicketApp.Signal.SignalRClient;

namespace TicketApp.Vistas
{
    public partial class frmAdmin : Form
    {
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService solicitudesService;

        private SignalRClient signalRClient;

        private List<Solicitud> solicitudes;
        public frmAdmin(TokenService loginService, ISolicitudesService solicitudesService)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";
            signalRClient = new SignalRClient(this, urlHub);

            this._tokenService = loginService;
            this.solicitudesService = solicitudesService;
            var loginResponse = _tokenService.LoginResponse;

            if (loginResponse != null)
            {


                labelUsuario.Text = loginResponse.userName;

                CargarSolicitudes();

            }
        }


        public async void CargarSolicitudes()
        {
            if (!await NetworkHelper.CheckInternetConnectionAsync())
            {
                MessageBox.Show("No hay conexión a internet", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            solicitudes = await solicitudesService.GetSolicitudes();
            if (solicitudes.Count == 0)
            {
                dataGridViewSolicitudes.Visible = false;
                label2.Visible = true;
                label1.Visible = false;
            }
            else
            {
                dataGridViewSolicitudes.Visible = true;
                label2.Visible = false;
                label1.Visible = true;
            }
            ActualizarUIConSolicitudes();
        }

        private void ActualizarUIConSolicitudes()
        {

            dataGridViewSolicitudes.DataSource = solicitudes;
            dataGridViewSolicitudes.Columns["Id"].Visible = false;
            dataGridViewSolicitudes.Columns["UsuarioId"].Visible = false;
            dataGridViewSolicitudes.Columns["ContadorMensajes"].Visible = false;

            ApplyConditionalFormatting();

        }


        private void ApplyConditionalFormatting()
        {
            foreach (DataGridViewRow row in dataGridViewSolicitudes.Rows)
            {
                if (row.Cells["EstadoActual"].Value?.ToString() == "PENDIENTE")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private async void frmAdmin_Load(object sender, EventArgs e)
        {
            await signalRClient.StartAsync();
        }

        private void selectItem()
        {
            object v = dataGridViewSolicitudes.CurrentRow.Cells;

            if (string.IsNullOrEmpty(dataGridViewSolicitudes.CurrentRow.Cells["Id"].Value.ToString()))
            {
                MessageBox.Show("Seleccione un registro",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                labelId.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Id"].Value);
                lblUsuario.Text = "Usuario: " + Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Usuario"].Value);
                labelEquipo.Text = "Equipo: " + Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Equipo"].Value);
                labelDepto.Text = "Departamento: " + Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Departamento"].Value);
            }
        }

        private void dataGridViewSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectItem();
        }

        private void dataGridViewSolicitudes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selectItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormDetalle frmDetalle = new FormDetalle(Int32.Parse(labelId.Text), solicitudesService);
                frmDetalle.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("No hay nada para ver!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        private async void btnNueva_ClickAsync(object sender, EventArgs e)
        {
            if (await NetworkHelper.CheckInternetConnectionAsync())
            {
                FormNuevo nuevo = new FormNuevo(_tokenService, solicitudesService);
                nuevo.Show();
            }
            else
            {
                MessageBox.Show("No hay conexión a internet", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void historialToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            if (!await NetworkHelper.CheckInternetConnectionAsync())
            {
                MessageBox.Show("No hay conexión a internet", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var historial = new Historial(_tokenService, solicitudesService);
            historial.Show();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {

            if (await NetworkHelper.CheckInternetConnectionAsync())
            {
                CargarSolicitudes();
            }
            else
            {
                MessageBox.Show("No hay conexión a internet", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewSolicitudes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridViewSolicitudes.Columns[e.ColumnIndex].Name == "Fecha" ||
                 dataGridViewSolicitudes.Columns[e.ColumnIndex].Name == "FechaEstado") &&
                 e.Value is DateTime fecha)
            {
                // Convierte la fecha a la hora local y formatea la visualización
                e.Value = fecha.ToLocalTime().ToString("g"); // Puedes ajustar el formato "g" según tus preferencias
                e.FormattingApplied = true;
            }
        }
    }
}
