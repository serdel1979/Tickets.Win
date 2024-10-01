using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;
using TicketApp.Services.Login;
using TicketApp.Services.Solicitudes;
using TicketApp.Vistas;

namespace TicketApp
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly IOptions<AppSettings> appSettings;
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService solicitudesService;
        private readonly AppSettings _appSettings;

        public Login(ILoginService loginService, IOptions<AppSettings> appSettings, TokenService tokenService,
            ISolicitudesService solicitudesService)
        {
            InitializeComponent();
            this._loginService = loginService;
            this.appSettings = appSettings;
            this._tokenService = tokenService;
            this.solicitudesService = solicitudesService;
            this._appSettings = appSettings.Value;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Ingresar();
            }
        }

        private async void Ingresar()
        {
            progressBarLogin.Visible = true;

            string username = txtUser.Text;
            string password = txtPassword.Text;
            string recaptchaToken = _appSettings.RecaptchaToken;

            var loginData = new LoginData
            {
                Usuario = username,
                Password = password,
                recaptchaToken = recaptchaToken
            };

            var response = await _loginService.LoginAsync(loginData);

            if (response != null && response.ok)
            {
                _tokenService.SetLoginResponse(response);
                LoginResponse resp = _tokenService.LoginResponse;

                if (resp.claims == 1)
                {
                    var frmAdmin = new frmAdmin(_tokenService, solicitudesService); // Pasar el servicio al nuevo formulario
                    frmAdmin.Show();
                    progressBarLogin.Visible = false;
                    this.Hide();
                }
                else
                {
                   var panelUsuarios = new frmPanelusrs(_tokenService, solicitudesService);
                    panelUsuarios.Show();
                    progressBarLogin.Visible = false;
                    this.Hide();
                }



            }
            else
            {
                // Manejar error de autenticación

                progressBarLogin.Visible = false;
                MessageBox.Show("No puede ingresar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Ingresar();
            }
        }
    }
}
