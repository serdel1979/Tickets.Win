namespace TicketApp.Vistas
{
    partial class FormNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBarNuevo = new ProgressBar();
            openFileImage = new OpenFileDialog();
            btnEnviar = new Button();
            btnCerrar = new Button();
            panel1 = new Panel();
            btnCargaImagen = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBoxImagen = new PictureBox();
            richTextDescripcion = new RichTextBox();
            txtEquipo = new TextBox();
            txtDepartamento = new TextBox();
            txtUsuario = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // progressBarNuevo
            // 
            progressBarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarNuevo.Location = new Point(0, 4);
            progressBarNuevo.MarqueeAnimationSpeed = 10;
            progressBarNuevo.Name = "progressBarNuevo";
            progressBarNuevo.Size = new Size(1032, 23);
            progressBarNuevo.Style = ProgressBarStyle.Marquee;
            progressBarNuevo.TabIndex = 0;
            progressBarNuevo.Visible = false;
            // 
            // openFileImage
            // 
            openFileImage.FileName = "openFileDialog1";
            openFileImage.Filter = "(*.png;*.jpg)|*.png;*.jpg\"";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(686, 597);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(174, 41);
            btnEnviar.TabIndex = 12;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(434, 597);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(174, 41);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCargaImagen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBoxImagen);
            panel1.Controls.Add(richTextDescripcion);
            panel1.Controls.Add(txtEquipo);
            panel1.Controls.Add(txtDepartamento);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(16, 37);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 484);
            panel1.TabIndex = 14;
            // 
            // btnCargaImagen
            // 
            btnCargaImagen.Location = new Point(116, 434);
            btnCargaImagen.Name = "btnCargaImagen";
            btnCargaImagen.Size = new Size(173, 31);
            btnCargaImagen.TabIndex = 21;
            btnCargaImagen.Text = "Cargar Imagen...";
            btnCargaImagen.UseVisualStyleBackColor = true;
            btnCargaImagen.Click += btnCargaImagen_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 284);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 20;
            label4.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 194);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 19;
            label3.Text = "Equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 135);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 18;
            label2.Text = "Departamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 70);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 17;
            label1.Text = "Usuario";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(598, 98);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(292, 315);
            pictureBoxImagen.TabIndex = 16;
            pictureBoxImagen.TabStop = false;
            // 
            // richTextDescripcion
            // 
            richTextDescripcion.Location = new Point(116, 302);
            richTextDescripcion.Name = "richTextDescripcion";
            richTextDescripcion.Size = new Size(385, 111);
            richTextDescripcion.TabIndex = 15;
            richTextDescripcion.Text = "";
            richTextDescripcion.TextChanged += richTextDescripcion_TextChanged_1;
            // 
            // txtEquipo
            // 
            txtEquipo.Location = new Point(120, 212);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(382, 23);
            txtEquipo.TabIndex = 14;
            txtEquipo.TextChanged += txtEquipo_TextChanged_1;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Enabled = false;
            txtDepartamento.Location = new Point(120, 153);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(382, 23);
            txtDepartamento.TabIndex = 13;
            txtDepartamento.TextChanged += txtDepartamento_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(120, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(382, 23);
            txtUsuario.TabIndex = 12;
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            // 
            // FormNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 665);
            Controls.Add(panel1);
            Controls.Add(btnCerrar);
            Controls.Add(btnEnviar);
            Controls.Add(progressBarNuevo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormNuevo";
            Text = "FormNuevo";
            Load += FormNuevo_LoadAsync;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBarNuevo;
        private TextBox textBox4;
        private OpenFileDialog openFileImage;
        private Button btnEnviar;
        private Button btnCerrar;
        private Panel panel1;
        private Button btnCargaImagen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBoxImagen;
        private RichTextBox richTextDescripcion;
        private TextBox txtEquipo;
        private TextBox txtDepartamento;
        private TextBox txtUsuario;
    }
}