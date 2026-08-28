using App.BL.Data.Repositories;
using App.BL.Services;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectsLibraryWinForms.Client.ViewModel;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class ListUsersForm : Form
    {
        private readonly UserService _userService;

        public ListUsersForm(UserService userService)
        {
            InitializeComponent();

            _userService = userService;
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            var usersDb = _userService.GetAllUsers();
            var usersViewModels = _userService.UserMapper(usersDb);

            dataGridView1.DataSource = usersViewModels;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            var listUsersForms = new AddUserForm(_userService);
            listUsersForms.ShowDialog();

            if (listUsersForms.DialogResult == DialogResult.OK)
            {
                ListUsers_Load( sender, e);
            }
        }
    }
}
