using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Services.Data
{
    public class LoginData
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string recaptchaToken { get; set; }
    }
}
