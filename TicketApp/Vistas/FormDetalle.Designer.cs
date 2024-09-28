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
            label9 = new Label();
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
            label1.Location = new Point(27, 121);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "DETALLE DE SOLICITUD";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label9);
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
            panel1.Location = new Point(27, 180);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 412);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(564, 308);
            label9.Name = "label9";
            label9.Size = new Size(433, 100);
            label9.TabIndex = 23;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(257, 336);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(0, 20);
            labelDescripcion.TabIndex = 22;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(257, 273);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(0, 20);
            labelFecha.TabIndex = 21;
            // 
            // labelEstadoActual
            // 
            labelEstadoActual.AutoSize = true;
            labelEstadoActual.Location = new Point(257, 209);
            labelEstadoActual.Name = "labelEstadoActual";
            labelEstadoActual.Size = new Size(0, 20);
            labelEstadoActual.TabIndex = 20;
            // 
            // labelEquipo
            // 
            labelEquipo.AutoSize = true;
            labelEquipo.Location = new Point(257, 144);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(0, 20);
            labelEquipo.TabIndex = 19;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(257, 85);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(0, 20);
            labelUsuario.TabIndex = 18;
            // 
            // labelDepartamento
            // 
            labelDepartamento.AutoSize = true;
            labelDepartamento.Location = new Point(257, 32);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(0, 20);
            labelDepartamento.TabIndex = 17;
            // 
            // listBoxEstados
            // 
            listBoxEstados.FormattingEnabled = true;
            listBoxEstados.Location = new Point(561, 85);
            listBoxEstados.Margin = new Padding(3, 4, 3, 4);
            listBoxEstados.Name = "listBoxEstados";
            listBoxEstados.Size = new Size(436, 204);
            listBoxEstados.TabIndex = 16;
            listBoxEstados.SelectedIndexChanged += listBoxEstados_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(561, 27);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 15;
            label8.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 336);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 14;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 273);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 209);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 12;
            label5.Text = "Estado actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 27);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 9;
            label2.Text = "Departamento";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(richTextBoxComentario);
            panel2.Controls.Add(comboBoxEstadosPosibles);
            panel2.Location = new Point(27, 601);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 304);
            panel2.TabIndex = 13;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(369, 229);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(223, 57);
            button2.TabIndex = 16;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(623, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(223, 57);
            button1.TabIndex = 15;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // richTextBoxComentario
            // 
            richTextBoxComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxComentario.Location = new Point(40, 116);
            richTextBoxComentario.Margin = new Padding(3, 4, 3, 4);
            richTextBoxComentario.Name = "richTextBoxComentario";
            richTextBoxComentario.Size = new Size(551, 71);
            richTextBoxComentario.TabIndex = 14;
            richTextBoxComentario.Text = "";
            richTextBoxComentario.TextChanged += richTextBoxComentario_TextChanged;
            // 
            // comboBoxEstadosPosibles
            // 
            comboBoxEstadosPosibles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEstadosPosibles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstadosPosibles.FormattingEnabled = true;
            comboBoxEstadosPosibles.Location = new Point(40, 36);
            comboBoxEstadosPosibles.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstadosPosibles.Name = "comboBoxEstadosPosibles";
            comboBoxEstadosPosibles.Size = new Size(182, 28);
            comboBoxEstadosPosibles.TabIndex = 13;
            // 
            // progressBarCarga
            // 
            progressBarCarga.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarCarga.BackColor = SystemColors.ActiveCaptionText;
            progressBarCarga.Location = new Point(-5, 16);
            progressBarCarga.Margin = new Padding(3, 4, 3, 4);
            progressBarCarga.MarqueeAnimationSpeed = 5;
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(1735, 31);
            progressBarCarga.Style = ProgressBarStyle.Marquee;
            progressBarCarga.TabIndex = 15;
            // 
            // FormDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 923);
            Controls.Add(progressBarCarga);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormDetalle";
            Text = "FormDetalle";
            Load += FormDetalle_LoadAsync;
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
        private Label label9;
    }
}