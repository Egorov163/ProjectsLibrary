namespace ProjectsLibraryWinForms.Forms.Users
{
    partial class AddUserForm
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
            textUserName = new TextBox();
            labNameUser = new Label();
            labPassword = new Label();
            textUserPassword = new TextBox();
            butAdd = new Button();
            SuspendLayout();
            // 
            // textUserName
            // 
            textUserName.Location = new Point(157, 6);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(329, 27);
            textUserName.TabIndex = 0;
            // 
            // labNameUser
            // 
            labNameUser.AutoSize = true;
            labNameUser.Location = new Point(12, 9);
            labNameUser.Name = "labNameUser";
            labNameUser.Size = new Size(139, 20);
            labNameUser.TabIndex = 1;
            labNameUser.Text = "Имя пользователя";
            // 
            // labPassword
            // 
            labPassword.AutoSize = true;
            labPassword.Location = new Point(12, 42);
            labPassword.Name = "labPassword";
            labPassword.Size = new Size(62, 20);
            labPassword.TabIndex = 2;
            labPassword.Text = "Пароль";
            // 
            // textUserPassword
            // 
            textUserPassword.Location = new Point(157, 39);
            textUserPassword.Name = "textUserPassword";
            textUserPassword.Size = new Size(329, 27);
            textUserPassword.TabIndex = 3;
            // 
            // butAdd
            // 
            butAdd.DialogResult = DialogResult.OK;
            butAdd.Location = new Point(12, 403);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(213, 35);
            butAdd.TabIndex = 4;
            butAdd.Text = "Добавить";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butAdd);
            Controls.Add(textUserPassword);
            Controls.Add(labPassword);
            Controls.Add(labNameUser);
            Controls.Add(textUserName);
            Name = "AddUserForm";
            Text = "AddUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUserName;
        private Label labNameUser;
        private Label labPassword;
        private TextBox textUserPassword;
        private Button butAdd;
    }
}