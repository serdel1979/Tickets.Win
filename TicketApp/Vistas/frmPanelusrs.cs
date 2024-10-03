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

        private void frmPanelusrs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmNuevo = new FormNuevo(_tokenService,solicitudesService);

            frmNuevo.Show();
        }


        public async void CargarSolicitudes()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al obtener solicitudes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
