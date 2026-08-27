namespace ProjectsLibraryWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            пользователиToolStripMenuItem1 = new ToolStripMenuItem();
            чайToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { пользователиToolStripMenuItem1, чайToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem1
            // 
            пользователиToolStripMenuItem1.Name = "пользователиToolStripMenuItem1";
            пользователиToolStripMenuItem1.Size = new Size(122, 24);
            пользователиToolStripMenuItem1.Text = "Пользователи";
            пользователиToolStripMenuItem1.Click += UsersToolStripMenuItem1_Click;
            // 
            // чайToolStripMenuItem
            // 
            чайToolStripMenuItem.Name = "чайToolStripMenuItem";
            чайToolStripMenuItem.Size = new Size(50, 24);
            чайToolStripMenuItem.Text = "Чай";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem пользователиToolStripMenuItem1;
        private ToolStripMenuItem чайToolStripMenuItem;
    }
}
