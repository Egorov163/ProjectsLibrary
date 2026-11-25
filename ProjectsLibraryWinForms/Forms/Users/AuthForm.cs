using App.BL.Contexts;
using App.BL.Services;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class AuthForm : Form
    {
        private readonly UserContext _userContext;
        private readonly UserService _userService;
        public AuthForm(UserContext userContext, UserService userService)
        {
            InitializeComponent();
            _userContext = userContext;
            _userService = userService;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var name = textUserName.Text;
            var pass = textUserPassword.Text;
            var user = _userService.GetUserByNameAndPassword(name, pass);

            if (user != null)
            {
                _userContext.SignIn(user);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
