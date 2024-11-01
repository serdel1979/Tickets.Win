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

        private const string FilePath = "data.txt";

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



        private void LoadLoginData()
        {
            if (File.Exists(FilePath))
            {
                string encryptedData = File.ReadAllText(FilePath);
                string decryptedData = Decrypt(encryptedData);
                string[] credentials = decryptedData.Split(':');
                if (credentials.Length == 2)
                {
                    txtUser.Text = credentials[0];
                    txtPassword.Text = credentials[1];
                    btnLogin.Focus();
                }
            }
        }

        private string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(encryptedBytes);
        }


        private void btnLogin_Click(object sender, EventArgs e)
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

                string encryptedData = File.Exists(FilePath) ? File.ReadAllText(FilePath) : null;
                string decryptedData = encryptedData != null ? Decrypt(encryptedData) : "";
                string[] storedCredentials = decryptedData.Split(':');

                if (storedCredentials.Length != 2 ||
                    storedCredentials[0] != username ||
                    storedCredentials[1] != password)
                {
                    // Si los valores ingresados son diferentes a los almacenados, se actualiza el archivo
                    string newData = $"{username}:{password}";
                    string newEncryptedData = Encrypt(newData);
                    File.WriteAllText(FilePath, newEncryptedData);
                }

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



        private string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainBytes);
        }



        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Ingresar();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadLoginData();
        }
    }
}
