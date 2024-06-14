using Newtonsoft.Json;
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

namespace TicketApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            progressBarLogin.Visible = true; 

            string username = txtUser.Text;
            string password = txtPassword.Text;
            string recaptchaToken = "6LeA3DEkAAAAAH2SpNpJpbHHOc6isGqIefkZX5TI"; // Mejor cargar esto desde una variable de entorno o un archivo de configuración

            var loginData = new LoginData
            {
                Usuario = username,
                Password = password,
                recaptchaToken = recaptchaToken
            };

            var response = await PostLoginAsync(loginData);

            if (response != null && response.ok)
            {
                // Login exitoso, abrir ventana principal
                /*  PrincipalForm principalForm = new PrincipalForm();
                  principalForm.Show();
                  this.Hide();*/

                progressBarLogin.Visible = false;
                MessageBox.Show("Acceso ok");
            }
            else
            {
                // Manejar error de autenticación

                progressBarLogin.Visible = false;
                MessageBox.Show("Error de autenticación, por favor verifica tus credenciales.");
            }
        }


        private async Task<LoginResponse> PostLoginAsync(LoginData loginData)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://tickets-dotnet-production.up.railway.app/api/usuarios/loginwin"; // Reemplaza con la URL real de tu API
                string json = JsonConvert.SerializeObject(loginData);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, data);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<LoginResponse>(result);
                }
                else
                {
                    // Manejar errores HTTP
                    return null;
                }
            }
        }





    }
}
