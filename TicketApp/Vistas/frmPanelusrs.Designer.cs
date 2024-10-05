namespace TicketApp.Vistas
{
    partial class frmPanelusrs
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
            panel1 = new Panel();
            labelUsuario = new Label();
            menuStrip1 = new MenuStrip();
            solicitudesToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            splitContainer2 = new SplitContainer();
            dataGridViewSolicitudes = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            progressBarEstados = new ProgressBar();
            label9 = new Label();
            listBoxEstados = new ListBox();
            button1 = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 151);
            panel1.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(14, 57);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(105, 29);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { solicitudesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1466, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // solicitudesToolStripMenuItem
            // 
            solicitudesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialToolStripMenuItem });
            solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            solicitudesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            solicitudesToolStripMenuItem.Size = new Size(95, 24);
            solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            historialToolStripMenuItem.Size = new Size(201, 26);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(0, 158);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Size = new Size(1466, 565);
            splitContainer2.SplitterDistance = 626;
            splitContainer2.TabIndex = 6;
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(14, 239);
            dataGridViewSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(682, 439);
            dataGridViewSolicitudes.TabIndex = 2;
            dataGridViewSolicitudes.CellContentClick += dataGridViewSolicitudes_CellContentClick;
            dataGridViewSolicitudes.CellEnter += dataGridViewSolicitudes_CellEnter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(progressBarEstados);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(listBoxEstados);
            panel2.Location = new Point(755, 239);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 439);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 49);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 27;
            label1.Text = "Estados de la solicitud seleccionada";
            // 
            // progressBarEstados
            // 
            progressBarEstados.Location = new Point(3, 3);
            progressBarEstados.MarqueeAnimationSpeed = 10;
            progressBarEstados.Name = "progressBarEstados";
            progressBarEstados.Size = new Size(689, 29);
            progressBarEstados.Style = ProgressBarStyle.Marquee;
            progressBarEstados.TabIndex = 26;
            progressBarEstados.Visible = false;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(106, 302);
            label9.Name = "label9";
            label9.Size = new Size(479, 115);
            label9.TabIndex = 25;
            // 
            // listBoxEstados
            // 
            listBoxEstados.FormattingEnabled = true;
            listBoxEstados.Location = new Point(106, 85);
            listBoxEstados.Margin = new Padding(3, 4, 3, 4);
            listBoxEstados.Name = "listBoxEstados";
            listBoxEstados.Size = new Size(479, 204);
            listBoxEstados.TabIndex = 24;
            listBoxEstados.SelectedIndexChanged += listBoxEstados_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(22, 159);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(202, 48);
            button1.TabIndex = 4;
            button1.Text = "Solicitar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPanelusrs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 763);
            Controls.Add(splitContainer2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dataGridViewSolicitudes);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPanelusrs";
            Text = "frmPanelusrs";
            FormClosing += frmPanelusrs_FormClosing;
            Load += frmPanelusrs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem solicitudesToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private DataGridView dataGridViewSolicitudes;
        private Panel panel2;
        private Button button1;
        private Label label9;
        private ListBox listBoxEstados;
        private ProgressBar progressBarEstados;
        private Label label1;
        private SplitContainer splitContainer2;
    }
}