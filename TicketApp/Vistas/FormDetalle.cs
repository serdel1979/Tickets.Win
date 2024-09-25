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
using TicketApp.Signal;
using static TicketApp.Signal.SignalRClient;

namespace TicketApp.Vistas
{
    public partial class FormDetalle : Form
    {
        private readonly int id;
        private readonly ISolicitudesService _solicitudes;

        private SignalRClient _signalRClient;

        private bool load1 = false;
        private bool load2 = false;

        public FormDetalle(int Id, ISolicitudesService solicitudes)
        {
            InitializeComponent();

            string urlHub = "https://tickets-dotnet-production.up.railway.app/Hubs/MHub";
           
            frmAdmin adminForm = Application.OpenForms.OfType<frmAdmin>().FirstOrDefault();
            _signalRClient = new SignalRClient(adminForm, urlHub);

            id = Id;
            this._solicitudes = solicitudes;
        }

        private async void FormDetalle_LoadAsync(object sender, EventArgs e)
        {
            cargaEstadosPosibles();
            cargaDetalle();
            await _signalRClient.StartAsync();
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

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBoxComentario.Text == "")
            {
                MessageBox.Show("Debe agregar un comentario", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (comboBoxEstadosPosibles.Text == "")
            {
                MessageBox.Show("Debe seleccionar un estado", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            progressBarCarga.Visible = true;

            NuevoEstado estado = new NuevoEstado
            {
                SolicitudId = id,
                Fecha = DateTime.Now,
                Comentario = richTextBoxComentario.Text,
                EstadoActual = comboBoxEstadosPosibles.Text,
            };
            try
            {
                await  _solicitudes.NuevoEstado(id, estado);
                progressBarCarga.Visible = false;
                MessageBox.Show("Estado actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var message = new SignalRClient.NewMessage("user", "refrescar", "refresh");
                await _signalRClient.SendMessageAsync(message);
            }
            catch (Exception)
            {
                progressBarCarga.Visible = false;
                MessageBox.Show("No se puede actualizar el estado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
