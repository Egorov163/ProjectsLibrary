using App.BL.Contexts;
using App.BL.Services;
using ProjectsLibraryWinForms.Client.ViewModel;

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

        /// <summary>
        /// Список чая
        /// </summary>
        private void ListTea_Load(object sender, EventArgs e)
        {
            var teaDb = _teaService.GetAllTea();
            var teaViewModels = _teaService.TeaMapper(teaDb);

            dataGridView1.DataSource = teaViewModels;
        }

        /// <summary>
        /// Добавить чай
        /// </summary>
        private void butAddTea_Click(object sender, EventArgs e)
        {
            var addTeaForm = new AddTeaForm(_teaService, _userContext);
            addTeaForm.ShowDialog();

            if (addTeaForm.DialogResult == DialogResult.OK)
            {
                ListTea_Load(sender, e);
            }
        }

        private void butDeleteTea_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран чай для удаления",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var selectedRows = dataGridView1.SelectedRows;

            for (int i = 0; i < selectedRows.Count; i++)
            {
                var o = dataGridView1.SelectedRows[i].DataBoundItem as TeaViewModel;

                if (o != null)
                {
                    _teaService.RemoveTea(o.Id);
                }
            }

            ListTea_Load(sender, e);
        }
    }
}
