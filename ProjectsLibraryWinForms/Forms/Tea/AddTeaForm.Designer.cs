namespace ProjectsLibraryWinForms.Forms.Users
{
    partial class AddTeaForm
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
            textTeaName = new TextBox();
            labNameTea = new Label();
            labType = new Label();
            butAdd = new Button();
            labelDateBuy = new Label();
            labelDescription = new Label();
            comboBoxType = new ComboBox();
            dateTimeDateBuy = new DateTimePicker();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // textTeaName
            // 
            textTeaName.Location = new Point(157, 6);
            textTeaName.Name = "textTeaName";
            textTeaName.Size = new Size(329, 27);
            textTeaName.TabIndex = 0;
            // 
            // labNameTea
            // 
            labNameTea.AutoSize = true;
            labNameTea.Location = new Point(9, 13);
            labNameTea.Name = "labNameTea";
            labNameTea.Size = new Size(105, 20);
            labNameTea.TabIndex = 1;
            labNameTea.Text = "Название чая";
            // 
            // labType
            // 
            labType.AutoSize = true;
            labType.Location = new Point(12, 49);
            labType.Name = "labType";
            labType.Size = new Size(63, 20);
            labType.TabIndex = 2;
            labType.Text = "Тип чая";
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
            // labelDateBuy
            // 
            labelDateBuy.AutoSize = true;
            labelDateBuy.Location = new Point(12, 82);
            labelDateBuy.Name = "labelDateBuy";
            labelDateBuy.Size = new Size(102, 20);
            labelDateBuy.TabIndex = 5;
            labelDateBuy.Text = "Дата покупки";
            labelDateBuy.Click += labelDateBuy_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 115);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(107, 20);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Описание чая";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(157, 41);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 7;
            // 
            // dateTimeDateBuy
            // 
            dateTimeDateBuy.Location = new Point(157, 75);
            dateTimeDateBuy.Name = "dateTimeDateBuy";
            dateTimeDateBuy.Size = new Size(250, 27);
            dateTimeDateBuy.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(157, 108);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(329, 27);
            textBoxDescription.TabIndex = 9;
            // 
            // AddTeaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDescription);
            Controls.Add(dateTimeDateBuy);
            Controls.Add(comboBoxType);
            Controls.Add(labelDescription);
            Controls.Add(labelDateBuy);
            Controls.Add(butAdd);
            Controls.Add(labType);
            Controls.Add(labNameTea);
            Controls.Add(textTeaName);
            Name = "AddTeaForm";
            Text = "AddUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTeaName;
        private Label labNameTea;
        private Label labType;
        private Button butAdd;
        private Label labelDateBuy;
        private Label labelDescription;
        private ComboBox comboBoxType;
        private DateTimePicker dateTimeDateBuy;
        private TextBox textBoxDescription;
    }
}