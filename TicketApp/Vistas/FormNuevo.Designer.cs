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
            txtUsuario = new TextBox();
            txtDepartamento = new TextBox();
            txtEquipo = new TextBox();
            richTextDescripcion = new RichTextBox();
            openFileImage = new OpenFileDialog();
            pictureBoxImagen = new PictureBox();
            btnCargaImagen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEnviar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // progressBarNuevo
            // 
            progressBarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarNuevo.Location = new Point(6, 4);
            progressBarNuevo.MarqueeAnimationSpeed = 10;
            progressBarNuevo.Name = "progressBarNuevo";
            progressBarNuevo.Size = new Size(1015, 23);
            progressBarNuevo.Style = ProgressBarStyle.Marquee;
            progressBarNuevo.TabIndex = 0;
            progressBarNuevo.Visible = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(208, 180);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(382, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Enabled = false;
            txtDepartamento.Location = new Point(208, 235);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(382, 23);
            txtDepartamento.TabIndex = 2;
            // 
            // txtEquipo
            // 
            txtEquipo.Location = new Point(208, 294);
            txtEquipo.Name = "txtEquipo";
            txtEquipo.Size = new Size(382, 23);
            txtEquipo.TabIndex = 3;
            // 
            // richTextDescripcion
            // 
            richTextDescripcion.Location = new Point(205, 384);
            richTextDescripcion.Name = "richTextDescripcion";
            richTextDescripcion.Size = new Size(385, 111);
            richTextDescripcion.TabIndex = 5;
            richTextDescripcion.Text = "";
            // 
            // openFileImage
            // 
            openFileImage.FileName = "openFileDialog1";
            openFileImage.Filter = "(*.png;*.jpg)|*.png;*.jpg\"";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(686, 180);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(292, 315);
            pictureBoxImagen.TabIndex = 6;
            pictureBoxImagen.TabStop = false;
            // 
            // btnCargaImagen
            // 
            btnCargaImagen.Location = new Point(205, 525);
            btnCargaImagen.Name = "btnCargaImagen";
            btnCargaImagen.Size = new Size(173, 31);
            btnCargaImagen.TabIndex = 7;
            btnCargaImagen.Text = "Cargar Imagen...";
            btnCargaImagen.UseVisualStyleBackColor = true;
            btnCargaImagen.Click += btnCargaImagen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 152);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 217);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 276);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Equipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 366);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Descripción";
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
            // FormNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 665);
            Controls.Add(btnCerrar);
            Controls.Add(btnEnviar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCargaImagen);
            Controls.Add(pictureBoxImagen);
            Controls.Add(richTextDescripcion);
            Controls.Add(txtEquipo);
            Controls.Add(txtDepartamento);
            Controls.Add(txtUsuario);
            Controls.Add(progressBarNuevo);
            Name = "FormNuevo";
            Text = "FormNuevo";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarNuevo;
        private TextBox txtUsuario;
        private TextBox txtDepartamento;
        private TextBox txtEquipo;
        private TextBox textBox4;
        private RichTextBox richTextDescripcion;
        private OpenFileDialog openFileImage;
        private PictureBox pictureBoxImagen;
        private Button btnCargaImagen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEnviar;
        private Button btnCerrar;
    }
}