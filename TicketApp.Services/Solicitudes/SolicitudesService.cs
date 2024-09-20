using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Services.Data;
using TicketApp.Services.Login;

namespace TicketApp.Services.Solicitudes
{
    public class SolicitudesService : ISolicitudesService
    {
        private readonly TokenService _tokenService;
        private readonly ApiSettings _apiSettings;

        public SolicitudesService(IOptions<ApiSettings> apiSettings, TokenService tokenService)
        {
            this._tokenService = tokenService;
            _apiSettings = apiSettings.Value;
        }

        public async Task<DetalleSolicitud> GetDetalleSolicitud(int Id)
        {
            using (HttpClient client = new HttpClient())
            {
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                // Construye la URL
                string url = $"{_apiSettings.BaseUrl}/solicitudes/{Id}";

                // Realiza la solicitud GET
                HttpResponseMessage response = await client.GetAsync(url);

                // Asegúrate de que la respuesta es exitosa
                response.EnsureSuccessStatusCode();

                // Lee y deserializa el contenido de la respuesta
                string responseBody = await response.Content.ReadAsStringAsync();
                DetalleSolicitud detalle = JsonConvert.DeserializeObject<DetalleSolicitud>(responseBody);

                return detalle;

            }
        }

        public async Task<List<EstadoPosible>> GetEstadoPosibles(int Id)
        {
            //https://tickets-dotnet-production.up.railway.app/api/solicitudes/estadosposibles/471
            using (HttpClient client = new HttpClient())
            {
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                // Construye la URL
                string url = $"{_apiSettings.BaseUrl}/solicitudes/estadosposibles/{Id}";

                // Realiza la solicitud GET
                HttpResponseMessage response = await client.GetAsync(url);

                // Asegúrate de que la respuesta es exitosa
                response.EnsureSuccessStatusCode();

                // Lee y deserializa el contenido de la respuesta
                string responseBody = await response.Content.ReadAsStringAsync();
                List<EstadoPosible> estados = JsonConvert.DeserializeObject<List<EstadoPosible>>(responseBody);

                return estados;

            }
        }

        async Task<List<Solicitud>> ISolicitudesService.GetSolicitudes()
        {
            using (HttpClient client = new HttpClient())
            {
                // Obtén el token utilizando el servicio de token
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }

                // Agrega el token al encabezado de la solicitud
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                // Construye la URL
                string url = $"{_apiSettings.BaseUrl}/solicitudes";

                // Realiza la solicitud GET
                HttpResponseMessage response = await client.GetAsync(url);

                // Asegúrate de que la respuesta es exitosa
                response.EnsureSuccessStatusCode();

                // Lee y deserializa el contenido de la respuesta
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Solicitud> solicitudes = JsonConvert.DeserializeObject<List<Solicitud>>(responseBody);

                return solicitudes;
            }
        }


    }
}
