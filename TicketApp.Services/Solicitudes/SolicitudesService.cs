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

        public async Task CrearSolicitud(NuevaSolicitud solicitud)
        {
            using (HttpClient client = new HttpClient())
            {
                // Obtén el token JWT
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                // Construye la URL
                string url = $"{_apiSettings.BaseUrl}/solicitudes";

                // Prepara el contenido de la solicitud multipart/form-data
                using (var content = new MultipartFormDataContent())
                {
                    // Añade la imagen binaria
                    if (solicitud.Imagen != null)
                    {
                        var imageContent = new ByteArrayContent(solicitud.Imagen);
                        imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                        content.Add(imageContent, "imagen", "imagen.png");
                    }

                    // Añade otros campos
                    content.Add(new StringContent(solicitud.UsuarioId.ToString()), "usuarioId");
                    content.Add(new StringContent(solicitud.Usuario), "usuario");
                    content.Add(new StringContent(solicitud.Departamento), "departamento");
                    content.Add(new StringContent(solicitud.Equipo), "equipo");
                    content.Add(new StringContent(solicitud.Descripcion), "descripcion");
                    content.Add(new StringContent(solicitud.Fecha.ToString("o")), "fecha");

                    // Envía la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Asegúrate de que la respuesta es exitosa
                    response.EnsureSuccessStatusCode();

                    // Lee la respuesta si es necesario
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Manejar la respuesta según tu necesidad
                }
            }
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

        public async Task<DetalleSolicitud> GetMiSolicitud(int Id)
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
                string url = $"{_apiSettings.BaseUrl}/solicitudes/getmisolicitud/{Id}";

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

        public async Task<List<Solicitud>> GetMisSolicitud()
        {
            using (HttpClient client = new HttpClient())
            {
                // Obtén el token utilizando el servicio de token
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }


                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                // Construye la URL
                string url = $"{_apiSettings.BaseUrl}/solicitudes/missolicitudes";

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

        public async Task NuevoEstado(int Id, NuevoEstado estado)
        {
            using (HttpClient client = new HttpClient())
            {
                var jwtToken = _tokenService.ParseToken();
                if (jwtToken == null)
                {
                    throw new InvalidOperationException("Token no disponible o inválido.");
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.RawData);

                string url = $"{_apiSettings.BaseUrl}/solicitudes/estados/{Id}/nuevo";

                var jsonContent = new StringContent(
                    JsonConvert.SerializeObject(estado),
                    Encoding.UTF8,
                    "application/json"
                );

                HttpResponseMessage response = await client.PostAsync(url, jsonContent);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error en la solicitud: {response.StatusCode}");
                }

                // Leer la respuesta si es necesario
                string responseBody = await response.Content.ReadAsStringAsync();

                // Puedes procesar la respuesta aquí si lo necesitas
                return;
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
