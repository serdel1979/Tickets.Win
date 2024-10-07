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
    public partial class Historial : Form
    {
        private readonly TokenService tokenService;
        private readonly ISolicitudesService solicitudesService;

        DataTable dataTable = new DataTable();

        List<Solicitud> solicitudes;  // Lista de datos (puedes usar el tipo adecuado)

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
                // Obtener las solicitudes desde el servicio
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
        }
    }
}
