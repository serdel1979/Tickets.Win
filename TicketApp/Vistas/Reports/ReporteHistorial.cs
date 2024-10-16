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

namespace TicketApp.Vistas.Reports
{
    public partial class ReporteHistorial : Form
    {
        private readonly List<Solicitud> solicitudes;

        public ReporteHistorial(List<Solicitud> solicitudes)
        {
            InitializeComponent();
            this.solicitudes = solicitudes;
        }

        private void ReporteHistorial_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "TicketApp.Vistas.Reports.Historial.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
