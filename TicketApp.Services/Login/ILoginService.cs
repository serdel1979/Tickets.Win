using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Services.Data;

namespace TicketApp.Services.Login
{
    public interface ILoginService
    {
        Task<LoginResponse> LoginAsync(LoginData loginData);
    }
}
