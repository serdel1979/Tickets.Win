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
            if (form is frmAdmin adminForm)
            {
                // Si el formulario es frmAdmin, llama al método CargarSolicitudes de frmAdmin
                adminForm.CargarSolicitudes();
            }
            else if (form is frmPanelusrs panelUsrsForm)
            {
                // Si el formulario es frmPanelusrs, llama al método que maneje las solicitudes en frmPanelusrs
                panelUsrsForm.CargarSolicitudes(); // Asegúrate de que frmPanelusrs tenga un método similar
            }
            else
            {
                // Manejo en caso de que el formulario no sea ninguno de los dos
                MessageBox.Show("Formulario no reconocido para actualizar las solicitudes.");
            }
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
