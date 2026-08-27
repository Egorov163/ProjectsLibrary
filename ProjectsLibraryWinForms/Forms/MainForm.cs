using App.BL.Data.Repositories;
using App.BL.Services;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectsLibraryWinForms.Forms.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectsLibraryWinForms
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;

        public MainForm(UserService userService)
        {
            InitializeComponent();

            _userService = userService;
        }

        private void UsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listUsersForms = new ListUsersForm(_userService);
            listUsersForms.ShowDialog();
        }
    }
}
