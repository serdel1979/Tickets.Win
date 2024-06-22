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
            dataGridViewSolicitudes = new DataGridView();
            labelDepto = new Label();
            lblUsuario = new Label();
            labelEquipo = new Label();
            button1 = new Button();
            labelId = new Label();
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            solicitudesToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 100);
            panel1.TabIndex = 0;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(36, 27);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(82, 23);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(12, 182);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.Size = new Size(780, 279);
            dataGridViewSolicitudes.TabIndex = 1;
            dataGridViewSolicitudes.CellContentClick += dataGridViewSolicitudes_CellContentClick;
            dataGridViewSolicitudes.CellEnter += dataGridViewSolicitudes_CellEnter;
            // 
            // labelDepto
            // 
            labelDepto.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDepto.Location = new Point(829, 218);
            labelDepto.Name = "labelDepto";
            labelDepto.Size = new Size(292, 18);
            labelDepto.TabIndex = 2;
            labelDepto.Text = "Departamento";
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(829, 266);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(292, 18);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // labelEquipo
            // 
            labelEquipo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipo.Location = new Point(829, 314);
            labelEquipo.Name = "labelEquipo";
            labelEquipo.Size = new Size(292, 18);
            labelEquipo.TabIndex = 4;
            labelEquipo.Text = "Equipo";
            // 
            // button1
            // 
            button1.Location = new Point(829, 378);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "DETALLE";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(833, 182);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 15);
            labelId.TabIndex = 7;
            labelId.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, solicitudesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1149, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, listadoToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            listadoToolStripMenuItem.Size = new Size(180, 22);
            listadoToolStripMenuItem.Text = "Listado";
            // 
            // solicitudesToolStripMenuItem
            // 
            solicitudesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialToolStripMenuItem });
            solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            solicitudesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            solicitudesToolStripMenuItem.Size = new Size(76, 20);
            solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            historialToolStripMenuItem.Size = new Size(161, 22);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 628);
            Controls.Add(labelId);
            Controls.Add(button1);
            Controls.Add(labelEquipo);
            Controls.Add(lblUsuario);
            Controls.Add(labelDepto);
            Controls.Add(dataGridViewSolicitudes);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdmin";
            Text = "Panel";
            Load += frmAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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