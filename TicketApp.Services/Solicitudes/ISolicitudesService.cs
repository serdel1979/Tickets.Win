﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Services.Data;

namespace TicketApp.Services.Solicitudes
{
    public interface ISolicitudesService
    {
        //https://tickets-dotnet-production.up.railway.app/api/solicitudes
        Task<List<Solicitud>> GetSolicitudes();

        Task<List<Solicitud>> GetAllSolicitudes();
        Task<List<Solicitud>> GetMisSolicitud();
        Task<List<EstadoPosible>> GetEstadoPosibles(int Id);
        Task<DetalleSolicitud> GetDetalleSolicitud(int Id);

        Task<DetalleSolicitud> GetMiSolicitud(int Id);

        Task NuevoEstado(int Id, NuevoEstado estado);

        Task CrearSolicitud(NuevaSolicitud nuevaSolicitud);
    }
}
