using Microsoft.IdentityModel.Tokens;
using System;
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
using TicketApp.Services.Solicitudes;
using TicketApp.Signal;
using static TicketApp.Signal.SignalRClient;

namespace TicketApp.Vistas
{
    public partial class FormDetalle : Form
    {
        private readonly int id;
        private readonly ISolicitudesService _solicitudes;

        private SignalRClient _signalRClient;

        public string UrlImagen { get; set; } = "";

        private bool load1 = false;
        private bool load2 = false;

        public FormDetalle(int Id, ISolicitudesService solicitudes)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";

            frmAdmin adminForm = Application.OpenForms.OfType<frmAdmin>().FirstOrDefault();
            _signalRClient = new SignalRClient(adminForm, urlHub);


            id = Id;
            this._solicitudes = solicitudes;
        }

        private async void FormDetalle_LoadAsync(object sender, EventArgs e)
        {
            cargaEstadosPosibles();
            cargaDetalle();
            await _signalRClient.StartAsync();
        }

        private void richToUpper(RichTextBox richText)
        {
            richText.Text = richText.Text.ToUpper();
            richText.SelectionStart = richText.Text.Length;
        }


        private async void cargaDetalle()
        {
            DetalleSolicitud detalleSolicitud = await _solicitudes.GetDetalleSolicitud(id);
            labelDepartamento.Text = detalleSolicitud.Departamento;
            labelUsuario.Text = detalleSolicitud.Usuario;
            labelEquipo.Text = detalleSolicitud.Equipo;
            labelDescripcion.Text = detalleSolicitud.Descripcion;
            labelEstadoActual.Text = detalleSolicitud.EstadoActual;
            labelFecha.Text = detalleSolicitud.Fecha.ToString("dd/MM/yyyy HH:mm:ss");
            UrlImagen = detalleSolicitud.UrlImagen;

            if (UrlImagen.IsNullOrEmpty())
            {
                btnVerImagen.Visible = false;
            }

            listBoxEstados.Items.Clear();
            foreach (var desc in detalleSolicitud.Estados)
            {
                listBoxEstados.Items.Add($"ESTADO: {desc.EstadoActual} | {desc.Comentario} | {desc.Fecha.ToString("dd/MM/yyyy HH:mm:ss")}");
            }

            load2 = true;
            panel1.Visible = load2;
        }

        private async void cargaEstadosPosibles()
        {
            comboBoxEstadosPosibles.Items.Clear();
            List<EstadoPosible> estados = await _solicitudes.GetEstadoPosibles(id);
            foreach (var estado in estados)
            {
                comboBoxEstadosPosibles.Items.Add(estado.Estado);
            }
            load1 = true;
            panel2.Visible = load1;
            progressBarCarga.Visible = !load1 && !load2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (!await NetworkHelper.CheckInternetConnectionAsync())
            {
                MessageBox.Show("No hay conexión a internet", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (richTextBoxComentario.Text == "")
            {
                MessageBox.Show("Debe agregar un comentario", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (comboBoxEstadosPosibles.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estado", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            progressBarCarga.Visible = true;

            NuevoEstado estado = new NuevoEstado
            {
                SolicitudId = id,
                Fecha = DateTime.Now,
                Comentario = richTextBoxComentario.Text,
                EstadoActual = comboBoxEstadosPosibles.Text,
            };
            try
            {
                await _solicitudes.NuevoEstado(id, estado);

                cargaDetalle();

                cargaEstadosPosibles();

                await _solicitudes.GetEstadoPosibles(id);

                progressBarCarga.Visible = false;
                MessageBox.Show("Estado actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var message = new SignalRClient.NewMessage("user", "refrescar", "refresh");
                await _signalRClient.SendMessageAsync(message);
            }
            catch (Exception)
            {
                progressBarCarga.Visible = false;
                MessageBox.Show("No se puede actualizar el estado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxComentario_TextChanged(object sender, EventArgs e)
        {
            richToUpper(sender as RichTextBox);
        }

        private void listBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = listBoxEstados.Text;
        }

        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            Imagen frmImagen = new Imagen(UrlImagen);
            frmImagen.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
