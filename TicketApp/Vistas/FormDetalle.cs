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
using TicketApp.Services.Solicitudes;

namespace TicketApp.Vistas
{
    public partial class FormDetalle : Form
    {
        private readonly int id;
        private readonly ISolicitudesService _solicitudes;

        private bool load1 = false;
        private bool load2 = false;

        public FormDetalle(int Id, ISolicitudesService solicitudes)
        {
            InitializeComponent();
            id = Id;
            this._solicitudes = solicitudes;
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            cargaEstadosPosibles();
            cargaDetalle();
        }



        private async void cargaDetalle()
        {
            DetalleSolicitud detalleSolicitud = await _solicitudes.GetDetalleSolicitud(id);
            labelDepartamento.Text = detalleSolicitud.Departamento;
            labelUsuario.Text = detalleSolicitud.Usuario;
            labelEquipo.Text = detalleSolicitud.Equipo;
            labelDescripcion.Text = detalleSolicitud.Descripcion;
            labelEstadoActual.Text = detalleSolicitud.EstadoActual;
            labelFecha.Text = detalleSolicitud.Fecha.ToString("dd/MM/yyyy HH:mm:ss");
            foreach (var desc in detalleSolicitud.Estados)
            {
                listBoxEstados.Items.Add($"ESTADO: {desc.EstadoActual}, {desc.Comentario} | {desc.Fecha.ToString("dd/MM/yyyy HH:mm:ss")}");
            }
            load2 = true;
            panel1.Visible = load2;
        }

        private async void cargaEstadosPosibles()
        {
            List<EstadoPosible> estados = await _solicitudes.GetEstadoPosibles(id);
            foreach (var estado in estados)
            {
                comboBoxEstadosPosibles.Items.Add(estado.Estado);
            }
            load1 = true;
            panel2.Visible = load1;
            progressBarCarga.Visible = !load1 && !load2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(richTextBoxComentario.Text == "")
            {
                MessageBox.Show("Debe agregar un comentario", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;                
            }

            if (comboBoxEstadosPosibles.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estado", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
    }
}
