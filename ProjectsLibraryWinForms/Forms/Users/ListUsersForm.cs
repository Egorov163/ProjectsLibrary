using App.BL.Contexts;
using App.BL.Services;
using ProjectsLibraryWinForms.Client.ViewModel;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class ListUsersForm : Form
    {
        private readonly UserService _userService;
        private readonly UserContext _userContext;

        public ListUsersForm(UserService userService, UserContext userContext)
        {
            InitializeComponent();

            _userService = userService;
            _userContext = userContext;
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
            var addUsersForm = new AddUserForm(_userService);
            addUsersForm.ShowDialog();

            if (addUsersForm.DialogResult == DialogResult.OK)
            {
                ListUsers_Load(sender, e);
            }
        }

        private void butDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран пользователь для удаления",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var selectedRows = dataGridView1.SelectedRows;

            for (int i = 0; i < selectedRows.Count; i++)
            {
                var user = dataGridView1.SelectedRows[i].DataBoundItem as UserViewModel;

                if (user != null)
                {
                    if (user.Name == "admin")
                    {
                        MessageBox.Show("Админа нельзя удалить",
                        "Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                        return;
                    }

                    _userService.RemoveUser(user.Id);
                }
            }

            ListUsers_Load(sender, e);
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            var authForm = new AuthForm(_userContext, _userService);
            authForm.ShowDialog();
        }
    }
}
