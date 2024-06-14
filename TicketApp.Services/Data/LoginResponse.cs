using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Services.Data
{
    public class LoginResponse
    {
            public bool ok { get; set; }
            public string id { get; set; }
            public string userName { get; set; }
            public string email { get; set; }
            public string token { get; set; }
            public int claims { get; set; }
            public DateTime expiracion { get; set; }
    }
}
