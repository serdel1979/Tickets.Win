﻿namespace TicketApp.Vistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            button1 = new Button();
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
            Report = new PrintPreviewDialog();
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
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer1.Size = new Size(1321, 852);
            splitContainer1.SplitterDistance = 753;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(progressBarSolicitudes);
            panel1.Controls.Add(textBoxFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 131);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(13, 45);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 41);
            button1.TabIndex = 2;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBarSolicitudes
            // 
            progressBarSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarSolicitudes.Location = new Point(3, 4);
            progressBarSolicitudes.Margin = new Padding(3, 4, 3, 4);
            progressBarSolicitudes.MarqueeAnimationSpeed = 10;
            progressBarSolicitudes.Name = "progressBarSolicitudes";
            progressBarSolicitudes.Size = new Size(750, 31);
            progressBarSolicitudes.Style = ProgressBarStyle.Marquee;
            progressBarSolicitudes.TabIndex = 1;
            progressBarSolicitudes.Visible = false;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilter.Location = new Point(3, 96);
            textBoxFilter.Margin = new Padding(3, 4, 3, 4);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(747, 27);
            textBoxFilter.TabIndex = 0;
            textBoxFilter.Text = "Filtrar";
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(0, 139);
            dataGridViewSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(753, 587);
            dataGridViewSolicitudes.TabIndex = 0;
            dataGridViewSolicitudes.CellContentClick += dataGridViewSolicitudes_CellContentClick;
            dataGridViewSolicitudes.CellEnter += dataGridViewSolicitudes_CellEnter;
            // 
            // progressBarEstados
            // 
            progressBarEstados.Location = new Point(208, 477);
            progressBarEstados.Margin = new Padding(3, 4, 3, 4);
            progressBarEstados.MarqueeAnimationSpeed = 10;
            progressBarEstados.Name = "progressBarEstados";
            progressBarEstados.Size = new Size(287, 31);
            progressBarEstados.Style = ProgressBarStyle.Marquee;
            progressBarEstados.TabIndex = 42;
            progressBarEstados.Visible = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(66, 15);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 20);
            labelId.TabIndex = 41;
            labelId.Visible = false;
            // 
            // btnVerImagen
            // 
            btnVerImagen.Location = new Point(58, 413);
            btnVerImagen.Margin = new Padding(3, 4, 3, 4);
            btnVerImagen.Name = "btnVerImagen";
            btnVerImagen.Size = new Size(117, 36);
            btnVerImagen.TabIndex = 40;
            btnVerImagen.Text = "Imagen";
            btnVerImagen.UseVisualStyleBackColor = true;
            btnVerImagen.Click += btnVerImagen_Click;
            // 
            // labelDetalleEstado
            // 
            labelDetalleEstado.BorderStyle = BorderStyle.Fixed3D;
            labelDetalleEstado.Location = new Point(58, 709);
            labelDetalleEstado.Name = "labelDetalleEstado";
            labelDetalleEstado.Size = new Size(437, 131);
            labelDetalleEstado.TabIndex = 39;
            // 
            // labelDescripcion
            // 
            labelDescripcion.BorderStyle = BorderStyle.Fixed3D;
            labelDescripcion.Location = new Point(208, 361);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(297, 88);
            labelDescripcion.TabIndex = 38;
            // 
            // labelFecha
            // 
            labelFecha.BorderStyle = BorderStyle.Fixed3D;
            labelFecha.Location = new Point(208, 300);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(298, 47);
            labelFecha.TabIndex = 37;
            // 
            // labelEstadoActual
            // 
            labelEstadoActual.BorderStyle = BorderStyle.Fixed3D;
            labelEstadoActual.Location = new Point(208, 236);
            labelEstadoActual.Name = "labelEstadoActual";
            labelEstadoActual.Size = new Size(298, 53);
            labelEstadoActual.TabIndex = 36;
            // 
            // labelEquipo
            // 
            labelEquipo.BorderStyle = BorderStyle.Fixed3D;
            labelEquipo.Location = new Point(208, 171);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(298, 53);
            labelEquipo.TabIndex = 35;
            // 
            // labelUsuario
            // 
            labelUsuario.BorderStyle = BorderStyle.Fixed3D;
            labelUsuario.Location = new Point(208, 104);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(298, 53);
            labelUsuario.TabIndex = 34;
            // 
            // labelDepartamento
            // 
            labelDepartamento.BorderStyle = BorderStyle.Fixed3D;
            labelDepartamento.Location = new Point(208, 36);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(298, 53);
            labelDepartamento.TabIndex = 33;
            // 
            // listBoxEstados
            // 
            listBoxEstados.FormattingEnabled = true;
            listBoxEstados.Location = new Point(58, 520);
            listBoxEstados.Margin = new Padding(3, 4, 3, 4);
            listBoxEstados.Name = "listBoxEstados";
            listBoxEstados.Size = new Size(436, 184);
            listBoxEstados.TabIndex = 32;
            listBoxEstados.SelectedIndexChanged += listBoxEstados_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 477);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 31;
            label8.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 363);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 30;
            label7.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 300);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 29;
            label6.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 236);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 28;
            label5.Text = "Estado actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 171);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 27;
            label4.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 112);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 26;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 25;
            label2.Text = "Departamento";
            // 
            // Report
            // 
            Report.AutoScrollMargin = new Size(0, 0);
            Report.AutoScrollMinSize = new Size(0, 0);
            Report.ClientSize = new Size(400, 300);
            Report.Enabled = true;
            Report.Icon = (Icon)resources.GetObject("Report.Icon");
            Report.Name = "printPreviewDialog1";
            Report.Visible = false;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 852);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1337, 888);
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
        private Button button1;
        private PrintPreviewDialog Report;
    }
}