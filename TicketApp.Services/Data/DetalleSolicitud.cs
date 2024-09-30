using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Services.Data
{
    public class DetalleSolicitud
    {
        public string Usuario { get; set; }
        public string Departamento { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string EstadoActual { get; set; }
        public  string UrlImagen { get; set; }
        public DateTime Fecha { get; set; }
        public List<Descripcion> Estados { get; set; }
    }
}
