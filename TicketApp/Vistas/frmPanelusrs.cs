using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;
using TicketApp.Services.Login;
using TicketApp.Services.Solicitudes;
using TicketApp.Signal;

namespace TicketApp.Vistas
{
    public partial class frmPanelusrs : Form
    {
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService solicitudesService;

        private SignalRClient signalRClient;
        private List<Solicitud> solicitudes;

        private DetalleSolicitud solicitudSelect;

        private int idSolicitudSelect;

        public frmPanelusrs(TokenService tokenService, ISolicitudesService solicitudesService)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";
            signalRClient = new SignalRClient(this, urlHub);

            this._tokenService = tokenService;
            this.solicitudesService = solicitudesService;

            var loginResponse = _tokenService.LoginResponse;

            if (loginResponse != null)
            {

                labelUsuario.Text = loginResponse.userName;

                CargarSolicitudes();

            }
        }

        private async void frmPanelusrs_Load(object sender, EventArgs e)
        {
            await signalRClient.StartAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmNuevo = new FormNuevo(_tokenService, solicitudesService);

            frmNuevo.Show();
        }


        private void ActualizarUIConSolicitudes()
        {

            dataGridViewSolicitudes.DataSource = solicitudes;
            dataGridViewSolicitudes.Columns["Id"].Visible = false;
            dataGridViewSolicitudes.Columns["UsuarioId"].Visible = false;
            dataGridViewSolicitudes.Columns["ContadorMensajes"].Visible = false;
            ApplyConditionalFormatting();
            if (solicitudes.Count == 0)
            {
                listBoxEstados.Items.Clear();
                label9.Text = "";
            }

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


        private async void selectItem()
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
                progressBarEstados.Visible = true;
                idSolicitudSelect = Convert.ToInt32(dataGridViewSolicitudes.CurrentRow.Cells["Id"].Value);
                solicitudSelect = await solicitudesService.GetMiSolicitud(idSolicitudSelect);
                listBoxEstados.Items.Clear();
                foreach (var estado in solicitudSelect.Estados)
                {
                    listBoxEstados.Items.Add($"{estado.EstadoActual} | {estado.Comentario} | {estado.Fecha}");
                }
                progressBarEstados.Visible = false;
            }
        }


        public async void CargarSolicitudes()
        {
            try
            {
                solicitudes = await solicitudesService.GetMisSolicitud();
                ActualizarUIConSolicitudes();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al obtener solicitudes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = listBoxEstados.Text;
        }
    }
}
