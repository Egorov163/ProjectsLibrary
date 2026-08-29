namespace ProjectsLibraryWinForms.Forms.Users
{
    partial class ListUsersForm
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
            dataGridView1 = new DataGridView();
            butAddUser = new Button();
            butDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 339);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // butAddUser
            // 
            butAddUser.Location = new Point(12, 357);
            butAddUser.Name = "butAddUser";
            butAddUser.Size = new Size(151, 37);
            butAddUser.TabIndex = 1;
            butAddUser.Text = "Добавить";
            butAddUser.UseVisualStyleBackColor = true;
            butAddUser.Click += butAddUser_Click;
            // 
            // butDeleteUser
            // 
            butDeleteUser.Location = new Point(169, 357);
            butDeleteUser.Name = "butDeleteUser";
            butDeleteUser.Size = new Size(151, 37);
            butDeleteUser.TabIndex = 2;
            butDeleteUser.Text = "Удалить";
            butDeleteUser.UseVisualStyleBackColor = true;
            butDeleteUser.Click += butDeleteUser_Click;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butDeleteUser);
            Controls.Add(butAddUser);
            Controls.Add(dataGridView1);
            Name = "ListUsersForm";
            Text = "ListUsers";
            Load += ListUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button butAddUser;
        private Button butDeleteUser;
    }
}