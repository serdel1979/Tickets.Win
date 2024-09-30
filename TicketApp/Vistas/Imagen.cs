using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp.Vistas
{
    public partial class Imagen : Form
    {
        private readonly string urlImagen;

        private bool isDragging = false;
        private Point startPosition;

        private float zoomFactor = 1.0f;
        private Point imageOffset = Point.Empty;  // Desplazamiento de la imagen
        private Point startDragPoint = Point.Empty;  // Punto de inicio del arrastre
        private Image imagenOriginal;



        private Size originalSize;
        public Imagen(string urlImagen)
        {
            InitializeComponent();
            this.urlImagen = urlImagen;
        }

        private async void Imagen_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;  // Mostrar el ProgressBar al iniciar la carga de la imagen
            pictureBox1.Visible = false;  // Ocultar el PictureBox mientras se carga la imagen

            imagenOriginal = await DescargarImagenDesdeUrlAsync(urlImagen);

            if (imagenOriginal != null)
            {
                originalSize = pictureBox1.Size;
                pictureBox1.Visible = true;  // Mostrar el PictureBox cuando la imagen esté lista
                progressBar1.Visible = false;  // Ocultar el ProgressBar al terminar de cargar
                pictureBox1.Invalidate();  // Redibujar el PictureBox
            }
            else
            {
                MessageBox.Show("No se pudo cargar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Visible = false;  // Ocultar el ProgressBar en caso de error
            }
        }



        private async Task<Image> DescargarImagenDesdeUrlAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return Image.FromStream(stream);  // Crear la imagen desde el stream
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void PictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Error != null)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Error al cargar la imagen: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            pictureBox1.Visible = true;
            progressBar1.Visible = false;
        }


        private async Task CargarImagenAsync(string url)
        {
            try
            {
                // Cargar la imagen de forma asíncrona
                pictureBox1.LoadAsync(url);

                // Si es una URL local
                // Para una URL remota, puedes usar lo siguiente:
                // pictureBox1.LoadAsync(url); 
                pictureBox1.Visible = true;
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomFactor *= 1.2f;  // Aumentar el factor de zoom
            pictureBox1.Invalidate();  // Redibujar el PictureBox con el nuevo zoom
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoomFactor /= 1.2f;  // Disminuir el factor de zoom
            pictureBox1.Invalidate();  // Redibujar el PictureBox con el nuevo zoom
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zoomFactor = 1.0f;  // Restablecer el factor de zoom a su valor original
            imageOffset = Point.Empty;  // Restablecer el desplazamiento a su valor original
            pictureBox1.Size = originalSize;  // Restablecer el tamaño del PictureBox si es necesario
            pictureBox1.Invalidate();  // Forzar el repintado
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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
                pictureBox1.Invalidate();

                // Actualizar el punto de inicio para el próximo movimiento
                startDragPoint = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                Cursor = Cursors.Default;  // Restaurar el cursor por defecto
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startDragPoint = e.Location;  // Guardar el punto de inicio del arrastre
                Cursor = Cursors.Hand;  // Cambiar el cursor mientras se arrastra
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (imagenOriginal != null)
            {
                // Calcular el área de dibujo basada en el zoom y el desplazamiento
                int width = (int)(imagenOriginal.Width * zoomFactor);
                int height = (int)(imagenOriginal.Height * zoomFactor);

                // Dibujar la imagen en las nuevas coordenadas
                e.Graphics.DrawImage(imagenOriginal, new Rectangle(imageOffset.X, imageOffset.Y, width, height));
            }
        }
    }
}
