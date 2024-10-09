namespace TicketApp.Vistas
{
    partial class Historial
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            progressBarSolicitudes = new ProgressBar();
            textBoxFilter = new TextBox();
            dataGridViewSolicitudes = new DataGridView();
            progressBarEstados = new ProgressBar();
            labelId = new Label();
            btnVerImagen = new Button();
            labelDetalleEstado = new Label();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(dataGridViewSolicitudes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(progressBarEstados);
            splitContainer1.Panel2.Controls.Add(labelId);
            splitContainer1.Panel2.Controls.Add(btnVerImagen);
            splitContainer1.Panel2.Controls.Add(labelDetalleEstado);
            splitContainer1.Panel2.Controls.Add(labelDescripcion);
            splitContainer1.Panel2.Controls.Add(labelFecha);
            splitContainer1.Panel2.Controls.Add(labelEstadoActual);
            splitContainer1.Panel2.Controls.Add(labelEquipo);
            splitContainer1.Panel2.Controls.Add(labelUsuario);
            splitContainer1.Panel2.Controls.Add(labelDepartamento);
            splitContainer1.Panel2.Controls.Add(listBoxEstados);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1156, 639);
            splitContainer1.SplitterDistance = 659;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBarSolicitudes);
            panel1.Controls.Add(textBoxFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 98);
            panel1.TabIndex = 1;
            // 
            // progressBarSolicitudes
            // 
            progressBarSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarSolicitudes.Location = new Point(3, 3);
            progressBarSolicitudes.MarqueeAnimationSpeed = 10;
            progressBarSolicitudes.Name = "progressBarSolicitudes";
            progressBarSolicitudes.Size = new Size(656, 23);
            progressBarSolicitudes.Style = ProgressBarStyle.Marquee;
            progressBarSolicitudes.TabIndex = 1;
            progressBarSolicitudes.Visible = false;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilter.Location = new Point(3, 72);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(654, 23);
            textBoxFilter.TabIndex = 0;
            textBoxFilter.Text = "Filtrar";
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(0, 104);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.Size = new Size(659, 440);
            dataGridViewSolicitudes.TabIndex = 0;
            dataGridViewSolicitudes.CellContentClick += dataGridViewSolicitudes_CellContentClick;
            dataGridViewSolicitudes.CellEnter += dataGridViewSolicitudes_CellEnter;
            // 
            // progressBarEstados
            // 
            progressBarEstados.Location = new Point(182, 358);
            progressBarEstados.MarqueeAnimationSpeed = 10;
            progressBarEstados.Name = "progressBarEstados";
            progressBarEstados.Size = new Size(251, 23);
            progressBarEstados.Style = ProgressBarStyle.Marquee;
            progressBarEstados.TabIndex = 42;
            progressBarEstados.Visible = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(58, 11);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 15);
            labelId.TabIndex = 41;
            labelId.Visible = false;
            // 
            // btnVerImagen
            // 
            btnVerImagen.Location = new Point(51, 310);
            btnVerImagen.Name = "btnVerImagen";
            btnVerImagen.Size = new Size(102, 27);
            btnVerImagen.TabIndex = 40;
            btnVerImagen.Text = "Imagen";
            btnVerImagen.UseVisualStyleBackColor = true;
            btnVerImagen.Click += btnVerImagen_Click;
            // 
            // labelDetalleEstado
            // 
            labelDetalleEstado.BorderStyle = BorderStyle.Fixed3D;
            labelDetalleEstado.Location = new Point(51, 532);
            labelDetalleEstado.Name = "labelDetalleEstado";
            labelDetalleEstado.Size = new Size(382, 98);
            labelDetalleEstado.TabIndex = 39;
            // 
            // labelDescripcion
            // 
            labelDescripcion.BorderStyle = BorderStyle.Fixed3D;
            labelDescripcion.Location = new Point(182, 271);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(260, 66);
            labelDescripcion.TabIndex = 38;
            // 
            // labelFecha
            // 
            labelFecha.BorderStyle = BorderStyle.Fixed3D;
            labelFecha.Location = new Point(182, 225);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(261, 35);
            labelFecha.TabIndex = 37;
            // 
            // labelEstadoActual
            // 
            labelEstadoActual.BorderStyle = BorderStyle.Fixed3D;
            labelEstadoActual.Location = new Point(182, 177);
            labelEstadoActual.Name = "labelEstadoActual";
            labelEstadoActual.Size = new Size(261, 40);
            labelEstadoActual.TabIndex = 36;
            // 
            // labelEquipo
            // 
            labelEquipo.BorderStyle = BorderStyle.Fixed3D;
            labelEquipo.Location = new Point(182, 128);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(261, 40);
            labelEquipo.TabIndex = 35;
            // 
            // labelUsuario
            // 
            labelUsuario.BorderStyle = BorderStyle.Fixed3D;
            labelUsuario.Location = new Point(182, 78);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(261, 40);
            labelUsuario.TabIndex = 34;
            // 
            // labelDepartamento
            // 
            labelDepartamento.BorderStyle = BorderStyle.Fixed3D;
            labelDepartamento.Location = new Point(182, 27);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(261, 40);
            labelDepartamento.TabIndex = 33;
            // 
            // listBoxEstados
            // 
            listBoxEstados.FormattingEnabled = true;
            listBoxEstados.ItemHeight = 15;
            listBoxEstados.Location = new Point(51, 390);
            listBoxEstados.Name = "listBoxEstados";
            listBoxEstados.Size = new Size(382, 139);
            listBoxEstados.TabIndex = 32;
            listBoxEstados.SelectedIndexChanged += listBoxEstados_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(51, 358);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 31;
            label8.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 272);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 30;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 225);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 29;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 177);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 28;
            label5.Text = "Estado actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 128);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 27;
            label4.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 84);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 26;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 40);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 25;
            label2.Text = "Departamento";
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 639);
            Controls.Add(splitContainer1);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewSolicitudes;
        private Panel panel1;
        private TextBox textBoxFilter;
        private ProgressBar progressBarSolicitudes;
        private Button btnVerImagen;
        private Label labelDetalleEstado;
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
        private Label labelId;
        private ProgressBar progressBarEstados;
    }
}