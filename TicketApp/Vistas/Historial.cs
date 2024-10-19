using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;
using TicketApp.Services.Login;
using TicketApp.Services.Solicitudes;

namespace TicketApp.Vistas
{
    public partial class Historial : Form
    {
        private readonly TokenService tokenService;
        private readonly ISolicitudesService solicitudesService;

        DataTable dataTable = new DataTable();

        List<Solicitud> solicitudes;  // Lista de datos (puedes usar el tipo adecuado)

        List<Solicitud> solicitudesFiltradas = new List<Solicitud>();

        DetalleSolicitud detalleSolicitud;

        private int currentPage = 0;

        public Historial(TokenService tokenService, ISolicitudesService solicitudesService)
        {
            InitializeComponent();
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;  // O BorderStyle.Fixed3D

            this.tokenService = tokenService;
            this.solicitudesService = solicitudesService;
        }

        private async void Historial_Load(object sender, EventArgs e)
        {
            progressBarSolicitudes.Visible = true;
            try
            {

                solicitudes = await solicitudesService.GetAllSolicitudes();

                // Cargar los datos en el DataGridView
                progressBarSolicitudes.Visible = false;
                LoadData(solicitudes); // Pasar las solicitudes obtenidas
            }
            catch (Exception)
            {
                progressBarSolicitudes.Visible = false;
                MessageBox.Show("No se puede acceder al historial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadData(List<Solicitud> solicitudes)
        {
            // Inicializar el DataTable solo una vez
            dataTable = new DataTable();

            // Crear el DataTable con las columnas necesarias
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("UsuarioId", typeof(string));
            dataTable.Columns.Add("ContadorMensajes", typeof(int));
            dataTable.Columns.Add("Departamento", typeof(string));
            dataTable.Columns.Add("Usuario", typeof(string));
            dataTable.Columns.Add("Descripcion", typeof(string));
            dataTable.Columns.Add("EstadoActual", typeof(string));
            dataTable.Columns.Add("Equipo", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));

            // Llenar el DataTable con los datos de la lista de solicitudes
            foreach (var solicitud in solicitudes)
            {
                dataTable.Rows.Add(
                    solicitud.Id,
                    solicitud.UsuarioId,
                    solicitud.ContadorMensajes,
                    solicitud.Departamento,
                    solicitud.Usuario,
                    solicitud.Descripcion,
                    solicitud.EstadoActual,
                    solicitud.Equipo,
                    solicitud.FechaEstado
                );
            }

            // Asignar el DataTable como la fuente de datos del DataGridView
            dataGridViewSolicitudes.DataSource = dataTable;
            solicitudesFiltradas = solicitudes.ToList();
            ActualizarUIConSolicitudes();
        }


        private void ActualizarUIConSolicitudes()
        {

            dataGridViewSolicitudes.DataSource = solicitudes;
            dataGridViewSolicitudes.Columns["Id"].Visible = false;
            dataGridViewSolicitudes.Columns["UsuarioId"].Visible = false;
            dataGridViewSolicitudes.Columns["ContadorMensajes"].Visible = false;

            ApplyConditionalFormatting();

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

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFilter.Text.Trim().Replace("'", "''"); // Escapar comillas simples para evitar errores

            // Aplicar el filtro al DataTable
            dataTable.DefaultView.RowFilter = $"Descripcion LIKE '%{filterText}%' " +
                                              $"OR Departamento LIKE '%{filterText}%' " +
                                              $"OR Usuario LIKE '%{filterText}%' " +
                                              $"OR EstadoActual LIKE '%{filterText}%'";
            dataGridViewSolicitudes.DataSource = dataTable;

            solicitudesFiltradas = dataTable.AsEnumerable().Select(row => new Solicitud
            {
                Id = row.Field<int>("Id"),
                UsuarioId = row.Field<string>("UsuarioId"),
                ContadorMensajes = row.Field<int>("ContadorMensajes"),
                Departamento = row.Field<string>("Departamento"),
                Usuario = row.Field<string>("Usuario"),
                Descripcion = row.Field<string>("Descripcion"),
                EstadoActual = row.Field<string>("EstadoActual"),
                Equipo = row.Field<string>("Equipo"),
                FechaEstado = row.Field<DateTime>("Fecha")
            }).ToList();
            currentPage = 0;
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
                labelId.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Id"].Value);
                labelUsuario.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Usuario"].Value);
                labelEquipo.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Equipo"].Value);
                labelDepartamento.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Departamento"].Value);
                labelDescripcion.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Descripcion"].Value);
                labelEstadoActual.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["EstadoActual"].Value);
                labelFecha.Text = Convert.ToString(dataGridViewSolicitudes.CurrentRow.Cells["Fecha"].Value);
                progressBarEstados.Visible = true;

                detalleSolicitud = await solicitudesService.GetDetalleSolicitud(Int32.Parse(labelId.Text));
                listBoxEstados.Items.Clear();
                foreach (var estado in detalleSolicitud.Estados)
                {
                    listBoxEstados.Items.Add($"ESTADO: {estado.EstadoActual} | {estado.Comentario} | {estado.Fecha.ToString("dd/MM/yyyy HH:mm:ss")}");
                }

                progressBarEstados.Visible = false;
            }
        }

        private void dataGridViewSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectItem();
        }

        private void dataGridViewSolicitudes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectItem();
        }

        private void listBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDetalleEstado.Text = listBoxEstados.Text;
        }

        private void btnVerImagen_Click(object sender, EventArgs e)
        {
            if (detalleSolicitud is not null && !detalleSolicitud.UrlImagen.IsNullOrEmpty())
            {
                Imagen frmImagen = new Imagen(detalleSolicitud.UrlImagen);
                frmImagen.Show();
            }
            else
            {
                MessageBox.Show("No se cargó imágen!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();

            // Configuración de la página
            document.DefaultPageSettings.PaperSize = new PaperSize("Carta", 850, 1100);
            document.DefaultPageSettings.Landscape = true;
            document.DocumentName = "Historial";

            // Suscribirse al evento PrintPage
            document.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Asignar el documento al PrintPreviewDialog
            Report.Document = document;
            Report.Activate();
            Report.ShowDialog();
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float yPos = e.MarginBounds.Top;
            int leftMargin = e.MarginBounds.Left;
            int lineHeight = (int)font.GetHeight(graphics) + 5; // Espacio entre líneas
            int maxLinesPerPage = (e.MarginBounds.Height / lineHeight) - 1; // Líneas que caben en la página
            Font headerFont = new Font("Arial", 12, FontStyle.Bold); // Fuente más grande y negrita
            float headerHeight = (int)headerFont.GetHeight(graphics) + 5; // Altura del encabezado

            // Imprimir encabezados solo en la primera página
            if (currentPage == 0)
            {
                // Asegúrate de que todos los encabezados se alineen bien y tengan el mismo tamaño
                graphics.DrawString("Usuario", headerFont, Brushes.Black, leftMargin, yPos);
                graphics.DrawString("Departamento", headerFont, Brushes.Black, leftMargin + 150, yPos);
                graphics.DrawString("Descripción", headerFont, Brushes.Black, leftMargin + 300, yPos);
                graphics.DrawString("Estado", headerFont, Brushes.Black, leftMargin + 600, yPos);
                graphics.DrawString("Fecha", headerFont, Brushes.Black, leftMargin + 700, yPos);

                yPos += headerHeight; // Aumentar la posición para el contenido
            }

            // Imprimir cada solicitud
            for (int i = currentPage * maxLinesPerPage; i < solicitudesFiltradas.Count; i++)
            {
                var solicitud = solicitudesFiltradas[i];



                // Medir la altura del texto para Usuario, Departamento y Descripción
                SizeF usuarioSize = graphics.MeasureString(solicitud.Usuario, font, new SizeF(150, float.MaxValue));
                SizeF departamentoSize = graphics.MeasureString(solicitud.Departamento, font, new SizeF(150, float.MaxValue));
                SizeF descripcionSize = graphics.MeasureString(solicitud.Descripcion, font, new SizeF(300, float.MaxValue));
                SizeF estadoSize = graphics.MeasureString(solicitud.EstadoActual, font, new SizeF(100, float.MaxValue));
                SizeF fechaSize = graphics.MeasureString(solicitud.FechaEstado.ToString("dd/MM/yyyy HH:mm"), font, new SizeF(100, float.MaxValue));

                // Calcular el mayor tamaño de los campos
                float maxHeight = Math.Max(usuarioSize.Height, Math.Max(departamentoSize.Height, Math.Max(descripcionSize.Height, Math.Max(estadoSize.Height, fechaSize.Height))));

                // Dibujar Usuario
                RectangleF usuarioRect = new RectangleF(leftMargin, yPos, 150, maxHeight);
                graphics.DrawString(solicitud.Usuario, font, Brushes.Black, usuarioRect);

                // Dibujar Departamento
                RectangleF departamentoRect = new RectangleF(leftMargin + 150, yPos, 150, maxHeight);
                graphics.DrawString(solicitud.Departamento, font, Brushes.Black, departamentoRect);

                // Dibujar Descripción
                RectangleF descripcionRect = new RectangleF(leftMargin + 300, yPos, 300, maxHeight);
                graphics.DrawString(solicitud.Descripcion, font, Brushes.Black, descripcionRect);

                // Dibujar Estado Actual
                RectangleF estadoRect = new RectangleF(leftMargin + 600, yPos, 100, maxHeight);
                graphics.DrawString(solicitud.EstadoActual, font, Brushes.Black, estadoRect);

                // Dibujar Fecha
                RectangleF fechaRect = new RectangleF(leftMargin + 700, yPos, 100, maxHeight);
                graphics.DrawString(solicitud.FechaEstado.ToString("dd/MM/yyyy HH:mm"), font, Brushes.Black, fechaRect);

                // Aumentar yPos según el tamaño máximo de la línea
                yPos += maxHeight + 5; // Agregar un margen entre filas

                // Controla si necesitas saltar de página
                if (yPos + maxHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // Indica que hay más páginas que imprimir
                    currentPage++; // Incrementar el número de página
                    return;
                }
            }

            e.HasMorePages = false; // No hay más páginas
            currentPage = 0;
        }

    }
}
