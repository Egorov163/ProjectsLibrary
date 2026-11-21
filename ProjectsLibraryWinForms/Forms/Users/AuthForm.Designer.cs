namespace ProjectsLibraryWinForms.Forms.Users
{
    partial class AuthForm
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
            textUserPassword = new TextBox();
            labPassword = new Label();
            labNameUser = new Label();
            textUserName = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textUserPassword
            // 
            textUserPassword.Location = new Point(157, 39);
            textUserPassword.Name = "textUserPassword";
            textUserPassword.Size = new Size(329, 27);
            textUserPassword.TabIndex = 7;
            // 
            // labPassword
            // 
            labPassword.AutoSize = true;
            labPassword.Location = new Point(12, 42);
            labPassword.Name = "labPassword";
            labPassword.Size = new Size(62, 20);
            labPassword.TabIndex = 6;
            labPassword.Text = "Пароль";
            // 
            // labNameUser
            // 
            labNameUser.AutoSize = true;
            labNameUser.Location = new Point(12, 9);
            labNameUser.Name = "labNameUser";
            labNameUser.Size = new Size(139, 20);
            labNameUser.TabIndex = 5;
            labNameUser.Text = "Имя пользователя";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(157, 6);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(329, 27);
            textUserName.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 111);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(119, 39);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(textUserPassword);
            Controls.Add(labPassword);
            Controls.Add(labNameUser);
            Controls.Add(textUserName);
            Name = "AuthForm";
            Text = "AuthForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUserPassword;
        private Label labPassword;
        private Label labNameUser;
        private TextBox textUserName;
        private Button buttonLogin;
    }
}