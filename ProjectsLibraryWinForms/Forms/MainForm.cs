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
        private readonly TeaService _teaService;

        public MainForm(UserService userService, 
            TeaService teaService)
        {
            InitializeComponent();

            _userService = userService;
            _teaService = teaService;
        }

        private void UsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listUsersForms = new ListUsersForm(_userService);
            listUsersForms.ShowDialog();
        }

        private void TeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listTeaForms = new ListTeaForm(_teaService);
            listTeaForms.ShowDialog();
        }
    }
}
