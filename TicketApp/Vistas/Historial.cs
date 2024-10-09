using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        DetalleSolicitud detalleSolicitud;

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
                    solicitud.Fecha
                );
            }

            // Asignar el DataTable como la fuente de datos del DataGridView
            dataGridViewSolicitudes.DataSource = dataTable;
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
            if(detalleSolicitud is not null &&  !detalleSolicitud.UrlImagen.IsNullOrEmpty())
            {
                Imagen frmImagen = new Imagen(detalleSolicitud.UrlImagen);
                frmImagen.Show();
            }
            else
            {
                MessageBox.Show("No se cargó imágen!!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
