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



        private bool isDragging = false;
        private Point startPosition;

        private float zoomFactor = 1.0f;
        private Point imageOffset = Point.Empty;  // Desplazamiento de la imagen
        private Point startDragPoint = Point.Empty;  // Punto de inicio del arrastre
        private Image imagenOriginal;
        private Size originalSize;


        private SignalRClient _signalRClient;
        private NuevaSolicitud solicitud { get; set; }
        public FormNuevo(TokenService tokenServic, ISolicitudesService solicitudes)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";

            // Verifica si frmAdmin está abierto
            frmAdmin adminForm = Application.OpenForms.OfType<frmAdmin>().FirstOrDefault();

            if (adminForm != null)
            {
                _signalRClient = new SignalRClient(adminForm, urlHub);
            }
            else
            {
                // Si frmAdmin no está abierto, puedes manejarlo de otra manera
                // Por ejemplo, pasar un formulario nulo u otro parámetro
                frmPanelusrs panelUsrsForm = Application.OpenForms.OfType<frmPanelusrs>().FirstOrDefault();
                if (panelUsrsForm != null)
                {
                    _signalRClient = new SignalRClient(panelUsrsForm, urlHub);
                }
                else
                {
                    // Manejo alternativo si ninguno de los formularios está abierto
                    MessageBox.Show("No se encontró un formulario válido para inicializar SignalRClient.");
                }
            }

            this._tokenService = tokenServic;
            this._solicitudes = solicitudes;

            solicitud = new NuevaSolicitud();
            solicitud.UsuarioId = _tokenService.GetIdUser();
            solicitud.Departamento = _tokenService.GetUserName().ToUpper();
            txtDepartamento.Text = solicitud.Departamento;

            pictureBoxImagen.AllowDrop = true;
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
                originalSize = pictureBoxImagen.Size;
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




        private async void FormNuevo_LoadAsync(object sender, EventArgs e)
        {
            await _signalRClient.StartAsync();
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {
            toUpper(sender as TextBox);
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

        private void button2_Click(object sender, EventArgs e)
        {
            zoomFactor /= 1.2f;  // Disminuir el factor de zoom
            pictureBoxImagen.Invalidate();  // Redibujar el PictureBox con el nuevo zoom
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomFactor *= 1.2f;  // Aumentar el factor de zoom
            pictureBoxImagen.Invalidate();  // Redibujar el PictureBox con el nuevo zoom
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.0f;  // Restablecer el factor de zoom a su valor original
            imageOffset = Point.Empty;  // Restablecer el desplazamiento a su valor original
            pictureBoxImagen.Invalidate();  // Forzar el repintado sin modificar el tamaño del PictureBox
        }


        private void pictureBoxImagen_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxImagen.Image != null)
            {
                // Limpiar el fondo del PictureBox antes de redibujar la imagen
                e.Graphics.Clear(pictureBoxImagen.BackColor);

                // Obtener el gráfico del PictureBox
                Graphics g = e.Graphics;

                // Calcular el nuevo tamaño de la imagen aplicando el zoom
                int newWidth = (int)(pictureBoxImagen.Image.Width * zoomFactor);
                int newHeight = (int)(pictureBoxImagen.Image.Height * zoomFactor);

                // Dibujar la imagen con el nuevo tamaño en el centro del PictureBox
                g.DrawImage(pictureBoxImagen.Image, new Rectangle(imageOffset.X, imageOffset.Y, newWidth, newHeight));
            }
        }

        private void pictureBoxImagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calcular la diferencia de movimiento
                int deltaX = e.X - startDragPoint.X;
                int deltaY = e.Y - startDragPoint.Y;

                // Actualizar el desplazamiento de la imagen
                imageOffset.X += deltaX;
                imageOffset.Y += deltaY;

                // Redibujar el PictureBox con la nueva posición
                pictureBoxImagen.Invalidate();

                // Actualizar el punto de inicio para el próximo movimiento
                startDragPoint = e.Location;
            }
        }

        private void pictureBoxImagen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                Cursor = Cursors.Default;  // Restaurar el cursor por defecto
            }
        }

        private void pictureBoxImagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startDragPoint = e.Location;  // Guardar el punto de inicio del arrastre
                Cursor = Cursors.Hand;  // Cambiar el cursor mientras se arrastra
            }
        }

        private void pictureBoxImagen_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;  // Muestra el cursor de copia
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBoxImagen_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Verifica si es una imagen y carga el primer archivo
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                pictureBoxImagen.Image = Image.FromFile(files[0]);

                // Si necesitas convertir la imagen en un byte[], puedes hacerlo así:
                byte[] imageBytes = File.ReadAllBytes(files[0]);
                solicitud.Imagen = imageBytes;  // Asignar la imagen al objeto 'NuevaSolicitud'
            }
        }

        private bool IsImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string fileExtension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(fileExtension);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
