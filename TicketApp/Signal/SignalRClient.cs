using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Vistas;

namespace TicketApp.Signal
{
    public class SignalRClient
    {
        private HubConnection connection;
        private Form form;

        public SignalRClient(Form form, string urlHub)
        {
            this.form = form;
            connection = new HubConnectionBuilder()
                .WithUrl(urlHub)
                .Build();

            // Configura los manejadores de eventos antes de iniciar la conexión
            ConfigureEventHandlers();
        }


        private void ConfigureEventHandlers()
        {
            connection.On<NewMessage>("NewMessage", (message) =>
            {
                form.Invoke((Action)(() => RefreshTable(message)));
            });
        }

        public async Task StartAsync()
        {
            try
            {
                await connection.StartAsync();
                await connection.InvokeAsync("JoinGroup", "refresh", "soporte");
                var testMessage = new NewMessage("TestUser", "Este es un mensaje de prueba", "refresh");
                await connection.InvokeAsync("SendMessage", testMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void RefreshTable(NewMessage message)
        {
            (form as frmAdmin).CargarSolicitudes();
        }


        public record NewMessage(string UserName, string Message, string GroupName);

        public async Task SendMessageAsync(NewMessage message)
        {
            try
            {
                await connection.InvokeAsync("SendMessage", message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar mensaje: {ex.Message}","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
