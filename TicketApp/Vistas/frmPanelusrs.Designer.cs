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
            dataGridViewSolicitudes = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1283, 100);
            panel1.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(12, 43);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(82, 23);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { solicitudesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1283, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            // dataGridViewSolicitudes
            // 
            dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitudes.Location = new Point(18, 179);
            dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            dataGridViewSolicitudes.Size = new Size(721, 329);
            dataGridViewSolicitudes.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button2);
            panel2.Location = new Point(760, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 330);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(23, 270);
            button2.Name = "button2";
            button2.Size = new Size(152, 34);
            button2.TabIndex = 0;
            button2.Text = "DETALLE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 119);
            button1.Name = "button1";
            button1.Size = new Size(177, 36);
            button1.TabIndex = 4;
            button1.Text = "Solicitar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmPanelusrs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 636);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dataGridViewSolicitudes);
            Controls.Add(panel1);
            Name = "frmPanelusrs";
            Text = "frmPanelusrs";
            Load += frmPanelusrs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitudes).EndInit();
            panel2.ResumeLayout(false);
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
        private Button button2;
        private Button button1;
    }
}