﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketApp.Services.Data;
using TicketApp.Services.Login;
using TicketApp.Services.Solicitudes;
using TicketApp.Signal;

namespace TicketApp.Vistas
{
    public partial class FormNuevo : Form
    {
        private readonly TokenService _tokenService;
        private readonly ISolicitudesService _solicitudes;

        private NuevaSolicitud solicitud { get; set; }
        public FormNuevo(TokenService tokenServic, ISolicitudesService solicitudes)
        {
            InitializeComponent();
            this._tokenService = tokenServic;
            this._solicitudes = solicitudes;

            solicitud = new NuevaSolicitud();

            solicitud.UsuarioId = _tokenService.GetIdUser();
            solicitud.Departamento = _tokenService.GetUserName().ToUpper();
            txtDepartamento.Text = solicitud.Departamento;

          //  MessageBox.Show(solicitud.UsuarioId);
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            // Mostrar el diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Si el usuario selecciona un archivo, obtén la ruta del archivo
                string filePath = openFileDialog.FileName;

                // Cargar la imagen en un control de imagen (PictureBox, por ejemplo)
                pictureBoxImagen.Image = Image.FromFile(filePath);

                // Si necesitas convertir la imagen en un byte[], puedes hacerlo así:
                byte[] imageBytes = File.ReadAllBytes(filePath);

                // Asigna la imagen al objeto NuevaSolicitud
                // nuevaSolicitud.Imagen = imageBytes;
                solicitud.Imagen = imageBytes;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtDepartamento.Text == "" || richTextDescripcion.Text == "")
                {
                    MessageBox.Show("No debe dejar campos vacíos","Datos inválidos",MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                solicitud.Equipo = txtEquipo.Text;
                solicitud.Usuario = txtUsuario.Text.ToUpper();
                solicitud.Descripcion = richTextDescripcion.Text.ToUpper();
                await _solicitudes.CrearSolicitud(solicitud);
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo crear la solicitud", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
