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

namespace TicketApp.Vistas
{
    public partial class frmAdmin : Form
    {
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService solicitudesService;

        private List<Solicitud> solicitudes;
        public frmAdmin(TokenService loginService, ISolicitudesService solicitudesService)
        {
            InitializeComponent();
            this._tokenService = loginService;
            this.solicitudesService = solicitudesService;
            var loginResponse = _tokenService.LoginResponse;

            if (loginResponse != null)
            {
                
                string jwtToken = loginResponse.token;
                string userName = loginResponse.userName;
                string email = loginResponse.email;
                int claims = loginResponse.claims;


                labelUsuario.Text = loginResponse.userName;

                CargarSolicitudes();

            }
        }


        private async void CargarSolicitudes()
        {
            try
            {
                solicitudes = await solicitudesService.GetSolicitudes();
                ActualizarUIConSolicitudes();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al obtener solicitudes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarUIConSolicitudes()
        {

            dataGridViewSolicitudes.DataSource = solicitudes;
        }



    }
}
