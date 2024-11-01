namespace TicketApp
{
    partial class Login
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
            labelUsuario = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            labelPassword = new Label();
            btnLogin = new Button();
            progressBarLogin = new ProgressBar();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(32, 119);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(75, 20);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario(*)";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(121, 115);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(244, 27);
            txtUser.TabIndex = 1;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 195);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 3;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(32, 195);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(61, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Clave(*)";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(151, 284);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_ClickAsync;
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(-1, 377);
            progressBarLogin.Margin = new Padding(3, 4, 3, 4);
            progressBarLogin.MarqueeAnimationSpeed = 1;
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(455, 31);
            progressBarLogin.Style = ProgressBarStyle.Marquee;
            progressBarLogin.TabIndex = 5;
            progressBarLogin.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 408);
            Controls.Add(progressBarLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtUser);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label labelPassword;
        private Button btnLogin;
        private ProgressBar progressBarLogin;
    }
}