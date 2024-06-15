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
using TicketApp.Vistas;

namespace TicketApp
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        private readonly AppSettings _appSettings;

        public Login(ILoginService loginService, IOptions<AppSettings> appSettings)
        {
            InitializeComponent();
            this._loginService = loginService;
            this._appSettings = appSettings.Value;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
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
                // Login exitoso, abrir ventana principal
                /*  PrincipalForm principalForm = new PrincipalForm();
                  principalForm.Show();
                  this.Hide();

                progressBarLogin.Visible = false;
                MessageBox.Show("Acceso ok", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Information); */
                var ventanaAdmin = new frmAdmin(); // Reemplaza con tu formulario principal
                ventanaAdmin.Show();

                this.Hide();
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


    }
}
