using App.BL.Services;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class AddUserForm : Form
    {
        private readonly UserService _userService;

        public AddUserForm(UserService userService)
        {
            InitializeComponent();

            _userService = userService;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var userName = textUserName.Text;
            var userPassword = textUserPassword.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userPassword))
            {
                _userService.AddUser(userName, userPassword);
                Close();
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
