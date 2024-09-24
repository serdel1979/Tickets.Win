namespace TicketApp.Vistas
{
    partial class FormDetalle
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
            label1 = new Label();
            panel1 = new Panel();
            labelDescripcion = new Label();
            labelFecha = new Label();
            labelEstadoActual = new Label();
            labelEquipo = new Label();
            labelUsuario = new Label();
            labelDepartamento = new Label();
            listBoxEstados = new ListBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            richTextBoxComentario = new RichTextBox();
            comboBoxEstadosPosibles = new ComboBox();
            progressBarCarga = new ProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 91);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "DETALLE DE SOLICITUD";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelDescripcion);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(labelEstadoActual);
            panel1.Controls.Add(labelEquipo);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(labelDepartamento);
            panel1.Controls.Add(listBoxEstados);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 310);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(225, 252);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(0, 15);
            labelDescripcion.TabIndex = 22;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(225, 205);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(0, 15);
            labelFecha.TabIndex = 21;
            // 
            // labelEstadoActual
            // 
            labelEstadoActual.AutoSize = true;
            labelEstadoActual.Location = new Point(225, 157);
            labelEstadoActual.Name = "labelEstadoActual";
            labelEstadoActual.Size = new Size(0, 15);
            labelEstadoActual.TabIndex = 20;
            // 
            // labelEquipo
            // 
            labelEquipo.AutoSize = true;
            labelEquipo.Location = new Point(225, 108);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(0, 15);
            labelEquipo.TabIndex = 19;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(225, 64);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(0, 15);
            labelUsuario.TabIndex = 18;
            // 
            // labelDepartamento
            // 
            labelDepartamento.AutoSize = true;
            labelDepartamento.Location = new Point(225, 24);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(0, 15);
            labelDepartamento.TabIndex = 17;
            // 
            // listBoxEstados
            // 
            listBoxEstados.FormattingEnabled = true;
            listBoxEstados.ItemHeight = 15;
            listBoxEstados.Location = new Point(491, 64);
            listBoxEstados.Name = "listBoxEstados";
            listBoxEstados.Size = new Size(249, 154);
            listBoxEstados.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(491, 20);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 15;
            label8.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 252);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 14;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 205);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 157);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Estado actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 108);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 64);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 20);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 9;
            label2.Text = "Departamento";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(richTextBoxComentario);
            panel2.Controls.Add(comboBoxEstadosPosibles);
            panel2.Location = new Point(24, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 229);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(323, 172);
            button2.Name = "button2";
            button2.Size = new Size(195, 43);
            button2.TabIndex = 16;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(545, 172);
            button1.Name = "button1";
            button1.Size = new Size(195, 43);
            button1.TabIndex = 15;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // richTextBoxComentario
            // 
            richTextBoxComentario.Location = new Point(35, 87);
            richTextBoxComentario.Name = "richTextBoxComentario";
            richTextBoxComentario.Size = new Size(483, 54);
            richTextBoxComentario.TabIndex = 14;
            richTextBoxComentario.Text = "";
            // 
            // comboBoxEstadosPosibles
            // 
            comboBoxEstadosPosibles.FormattingEnabled = true;
            comboBoxEstadosPosibles.Location = new Point(35, 27);
            comboBoxEstadosPosibles.Name = "comboBoxEstadosPosibles";
            comboBoxEstadosPosibles.Size = new Size(160, 23);
            comboBoxEstadosPosibles.TabIndex = 13;
            // 
            // progressBarCarga
            // 
            progressBarCarga.BackColor = SystemColors.ActiveCaptionText;
            progressBarCarga.Location = new Point(-4, 12);
            progressBarCarga.MarqueeAnimationSpeed = 5;
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(1518, 23);
            progressBarCarga.Style = ProgressBarStyle.Marquee;
            progressBarCarga.TabIndex = 15;
            // 
            // FormDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 692);
            Controls.Add(progressBarCarga);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDetalle";
            Text = "FormDetalle";
            Load += FormDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelDescripcion;
        private Label labelFecha;
        private Label labelEstadoActual;
        private Label labelEquipo;
        private Label labelUsuario;
        private Label labelDepartamento;
        private ListBox listBoxEstados;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private RichTextBox richTextBoxComentario;
        private ComboBox comboBoxEstadosPosibles;
        private ProgressBar progressBarCarga;
        private Button button2;
    }
}