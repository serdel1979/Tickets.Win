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
    public partial class FormNuevo : Form
    {
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService _solicitudes;


        private SignalRClient _signalRClient;
        private NuevaSolicitud solicitud { get; set; }
        public FormNuevo(TokenService tokenServic, ISolicitudesService solicitudes)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";

            frmAdmin adminForm = Application.OpenForms.OfType<frmAdmin>().FirstOrDefault();
            _signalRClient = new SignalRClient(adminForm, urlHub);

            this._tokenService = tokenServic;
            this._solicitudes = solicitudes;

            solicitud = new NuevaSolicitud();

            solicitud.UsuarioId = _tokenService.GetIdUser();
            solicitud.Departamento = _tokenService.GetUserName().ToUpper();
            txtDepartamento.Text = solicitud.Departamento;

            //  MessageBox.Show(solicitud.UsuarioId);
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            // Mostrar el diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, obtén la ruta del archivo
                string filePath = openFileDialog.FileName;

                // Cargar la imagen en un control de imagen (PictureBox, por ejemplo)
                pictureBoxImagen.Image = Image.FromFile(filePath);

                // Si necesitas convertir la imagen en un byte[], puedes hacerlo así:
                byte[] imageBytes = File.ReadAllBytes(filePath);

                // Asigna la imagen al objeto NuevaSolicitud
                // nuevaSolicitud.Imagen = imageBytes;
                solicitud.Imagen = imageBytes;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtDepartamento.Text == "" || richTextDescripcion.Text == "")
                {
                    MessageBox.Show("No debe dejar campos vacíos", "Datos inválidos", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                progressBarNuevo.Visible = true;
                solicitud.Equipo = txtEquipo.Text.ToUpper();
                solicitud.Usuario = txtUsuario.Text.ToUpper();
                solicitud.Descripcion = richTextDescripcion.Text.ToUpper();
                await _solicitudes.CrearSolicitud(solicitud);
                progressBarNuevo.Visible = false;

                txtEquipo.Text = "";
                txtUsuario.Text = "";
                richTextDescripcion.Text = "";

                pictureBoxImagen.Image = null;

                var message = new SignalRClient.NewMessage("user", "refrescar", "refresh");
                await _signalRClient.SendMessageAsync(message);

                MessageBox.Show("Solicitud enviada", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                progressBarNuevo.Visible = false;
                MessageBox.Show("No se pudo crear la solicitud", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void richToUpper(RichTextBox richText)
        {
            richText.Text = richText.Text.ToUpper();
            richText.SelectionStart = richText.Text.Length;
        }

        private void toUpper(TextBox textBox)
        {
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            toUpper(sender as TextBox);
        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {
            toUpper(sender as TextBox);
        }

        private void richTextDescripcion_TextChanged(object sender, EventArgs e)
        {
            richToUpper(sender as RichTextBox);
        }

        private async void FormNuevo_LoadAsync(object sender, EventArgs e)
        {
            await _signalRClient.StartAsync();
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            toUpper(sender as TextBox);
        }

        private void txtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipo_TextChanged_1(object sender, EventArgs e)
        {
            toUpper(sender as TextBox);
        }

        private void richTextDescripcion_TextChanged_1(object sender, EventArgs e)
        {
            richToUpper(sender as RichTextBox);
        }

        private void btnCargaImagen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            // Mostrar el diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, obtén la ruta del archivo
                string filePath = openFileDialog.FileName;

                // Cargar la imagen en un control de imagen (PictureBox, por ejemplo)
                pictureBoxImagen.Image = Image.FromFile(filePath);

                // Si necesitas convertir la imagen en un byte[], puedes hacerlo así:
                byte[] imageBytes = File.ReadAllBytes(filePath);

                // Asigna la imagen al objeto NuevaSolicitud
                // nuevaSolicitud.Imagen = imageBytes;
                solicitud.Imagen = imageBytes;
            }
        }
    }
}
