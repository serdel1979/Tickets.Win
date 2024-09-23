using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Services.Data
{
    public class NuevoEstado
    {
        public string Comentario { get; set; }
        public string EstadoActual { get; set; }
        public DateTime Fecha { get; set; }
        public int SolicitudId { get; set; }
    }
}
