using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Services.Data;

namespace TicketApp.Services.Login
{
    public class LoginService : ILoginService
    {


        private readonly ApiSettings _apiSettings;
        private readonly TokenService _tokenService;
        public LoginService(IOptions<ApiSettings> apiSettings, TokenService tokenService)
        {
            _apiSettings = apiSettings.Value; 
            _tokenService = tokenService;
        }


        public async Task<LoginResponse> LoginAsync(LoginData loginData)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{_apiSettings.BaseUrl}/usuarios/loginwin"; 
                string json = JsonConvert.SerializeObject(loginData);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, data);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    LoginResponse daraResponse = new LoginResponse();

                    daraResponse = JsonConvert.DeserializeObject<LoginResponse>(result)!;

                    _tokenService.SetLoginResponse(daraResponse);

                    return daraResponse;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
