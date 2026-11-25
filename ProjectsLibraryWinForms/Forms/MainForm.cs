using App.BL.Contexts;
using App.BL.Data.Repositories;
using App.BL.Services;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectsLibraryWinForms.Forms.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectsLibraryWinForms
{
    public partial class MainForm : Form
    {
        private readonly UserContext _userContext;
        private readonly UserService _userService;
        private readonly TeaService _teaService;

        public MainForm(UserContext userContext,
            UserService userService, 
            TeaService teaService)
        {
            InitializeComponent();

            _userContext = userContext;
            _userService = userService;
            _teaService = teaService;

            _userContext.UserChanged += UpdateUserNameLabel;
        }

        private void UpdateUserNameLabel()
        {
            var user = _userContext.CurrentUser;
            labelAuth.Text = user is null ? "Гость" : $"Вы вошли как {user.Name}";
        }

        private void UsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listUsersForms = new ListUsersForm(_userService, _userContext);
            listUsersForms.ShowDialog();
        }

        private void TeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listTeaForms = new ListTeaForm(_teaService, _userContext);
            listTeaForms.ShowDialog();
        }
    }
}
