using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Services.Data
{
    public class NuevaSolicitud
    {
        public byte[] Imagen { get; set; }
        public string UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Departamento { get; set; }
        public string Equipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
