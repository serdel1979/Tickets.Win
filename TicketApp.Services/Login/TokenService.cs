using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Services.Data;

namespace TicketApp.Services.Login
{
    public class TokenService
    {

        private LoginResponse _loginResponse;

        public LoginResponse LoginResponse
        {
            get { return _loginResponse; }
            set { _loginResponse = value; }
        }

        public void SetLoginResponse(LoginResponse loginResponse)
        {
            _loginResponse = loginResponse;
        }

        public void ClearLoginResponse()
        {
            _loginResponse = null;
        }



        public JwtSecurityToken ParseToken()
        {
            if (_loginResponse == null || string.IsNullOrEmpty(_loginResponse.token))
                return null;

            var handler = new JwtSecurityTokenHandler();
            return handler.ReadJwtToken(_loginResponse.token);
        }

        public Claim GetClaim(string claimType)
        {
            var token = ParseToken();
            return token?.Claims.FirstOrDefault(c => c.Type == claimType);
        }

        public string GetIdUser()
        {
            return _loginResponse.id;
        }


        public string GetUserName()
        {
            return _loginResponse.userName;
        }

    }
}
