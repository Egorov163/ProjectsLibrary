using App.BL.Contexts;
using App.BL.Services;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class ListTeaForm : Form
    {
        private readonly TeaService _teaService;
        private readonly UserContext _userContext;

        public ListTeaForm(TeaService teaService, UserContext userContext)
        {
            InitializeComponent();

            _teaService = teaService;
            _userContext = userContext;
        }

        private void ListTea_Load(object sender, EventArgs e)
        {
            var teaDb = _teaService.GetAllTea();
            var teaViewModels = _teaService.TeaMapper(teaDb);

            dataGridView1.DataSource = teaViewModels;

            
        }

        private void butAddTea_Click(object sender, EventArgs e)
        {
            var addTeaForm = new AddTeaForm(_teaService);
            addTeaForm.ShowDialog();

            if (addTeaForm.DialogResult == DialogResult.OK)
            {
                ListTea_Load(sender, e);
            }
        }

        private void butDeleteTea_Click(object sender, EventArgs e)
        {

        }

    }
}
