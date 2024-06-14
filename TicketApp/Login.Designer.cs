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
            labelUsuario.Location = new Point(28, 89);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(60, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario(*)";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(106, 86);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(214, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(28, 146);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Clave(*)";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(132, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(-1, 283);
            progressBarLogin.MarqueeAnimationSpeed = 1;
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(398, 23);
            progressBarLogin.Style = ProgressBarStyle.Marquee;
            progressBarLogin.TabIndex = 5;
            progressBarLogin.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 306);
            Controls.Add(progressBarLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtUser);
            Controls.Add(labelUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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