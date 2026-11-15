using App.BL.Services;
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
                var o = dataGridView1.SelectedRows[i].DataBoundItem as UserViewModel;

                if (o != null)
                {
                    _userService.RemoveUser(o.Id);
                }
            }

            ListUsers_Load(sender, e);
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            var authForm = new AuthForm();
            authForm.ShowDialog();

            if (authForm.DialogResult == DialogResult.OK)
            {
                ListUsers_Load(sender, e);
            }
        }
    }
}
