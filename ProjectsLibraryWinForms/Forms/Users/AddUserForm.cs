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

        }
    }
}
