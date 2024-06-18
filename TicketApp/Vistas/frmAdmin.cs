using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Login;

namespace TicketApp.Vistas
{
    public partial class frmAdmin : Form
    {
        private readonly TokenService _tokenService;

        public frmAdmin(TokenService loginService)
        {
            InitializeComponent();
            this._tokenService = loginService;

            var loginResponse = _tokenService.LoginResponse;

            if (loginResponse != null)
            {
                
                string jwtToken = loginResponse.token;
                string userName = loginResponse.userName;
                string email = loginResponse.email;
                int claims = loginResponse.claims;

            }
        }


    }
}
