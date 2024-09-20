namespace TicketApp.Vistas
{
    partial class frmAdmin
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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            solicitudesToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewSolicitudes = new DataGridView();
            labelDepto = new Label();
            lblUsuario = new Label();
            labelEquipo = new Label();
            button1 = new Button();
            labelId = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1313, 133);
            panel1.TabIndex = 0;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(41, 36);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(105, 29);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, solicitudesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1313, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, listadoToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(189, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            listadoToolStripMenuItem.Size = new Size(189, 26);
            listadoToolStripMenuItem.Text = "Listado";
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
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(14, 243);
            dataGridViewSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.RowHeadersWidth = 51;
            dataGridViewSolicitudes.Size = new Size(891, 372);
            dataGridViewSolicitudes.TabIndex = 1;
            dataGridViewSolicitudes.CellContentClick += dataGridViewSolicitudes_CellContentClick;
            dataGridViewSolicitudes.CellEnter += dataGridViewSolicitudes_CellEnter;
            // 
            // labelDepto
            // 
            labelDepto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDepto.Location = new Point(947, 291);
            labelDepto.Name = "labelDepto";
            labelDepto.Size = new Size(334, 24);
            labelDepto.TabIndex = 2;
            labelDepto.Text = "Departamento";
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(947, 355);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(334, 24);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // labelEquipo
            // 
            labelEquipo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipo.Location = new Point(947, 419);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(334, 24);
            labelEquipo.TabIndex = 4;
            labelEquipo.Text = "Equipo";
            // 
            // button1
            // 
            button1.Location = new Point(947, 504);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "DETALLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(952, 243);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 20);
            labelId.TabIndex = 7;
            labelId.Visible = false;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 837);
            Controls.Add(labelId);
            Controls.Add(button1);
            Controls.Add(labelEquipo);
            Controls.Add(lblUsuario);
            Controls.Add(labelDepto);
            Controls.Add(dataGridViewSolicitudes);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdmin";
            Text = "Panel";
            Load += frmAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelUsuario;
        private DataGridView dataGridViewSolicitudes;
        private Label labelDepto;
        private Label lblUsuario;
        private Label labelEquipo;
        private Button button1;
        private Label labelId;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem solicitudesToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
    }
}