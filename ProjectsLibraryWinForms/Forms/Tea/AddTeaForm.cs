using App.BL.Contexts;
using App.BL.Data.DbModels;
using App.BL.Data.Tea;
using App.BL.Services;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class AddTeaForm : Form
    {
        private readonly TeaService _teaService;
        private readonly UserContext _userContext;

        public AddTeaForm(TeaService teaService, UserContext userContext)
        {
            InitializeComponent();
            _teaService = teaService;
            _userContext = userContext;

            InitValues();
        }

        private void InitValues()
        {
            // Заполнить comboBox с типами чая.
            var types = Enum.GetValues(typeof(TeaType));
            comboBoxType.DataSource = types;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var user = _userContext.CurrentUser;
            var teaName = textTeaName.Text;
            var type = comboBoxType.SelectedItem.ToString();
            var dateBuy = DateOnly.FromDateTime(dateTimeDateBuy.Value); ;
            var description = textBoxDescription.Text;

            var dbModel = new TeaDbModel()
            {
                Name = teaName,
                DateBuy = dateBuy,
                Description = description,
                Type = type,
                User = user
            };

            _teaService.AddTea(dbModel);
        }

        private void labelDateBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
