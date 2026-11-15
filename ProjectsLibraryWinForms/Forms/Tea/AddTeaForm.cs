using App.BL.Data.DbModels;
using App.BL.Data.Tea;
using App.BL.Services;

namespace ProjectsLibraryWinForms.Forms.Users
{
    public partial class AddTeaForm : Form
    {
        private readonly TeaService _teaService;

        public AddTeaForm(TeaService teaService)
        {
            InitializeComponent();
            _teaService = teaService;

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
            var teaName = textTeaName.Text;
            var type = comboBoxType.SelectedItem.ToString();
            var dateBuy = dateTimeDateBuy.Value;
            var description = textBoxDescription.Text;

            //var dbModel = new TeaDbModel()
            //{
            //    Name = teaName,
            //    DateBuy = dateBuy,
            //    Description = description,
            //    Type = type,
            //    User = 
            //};

            //_teaService.AddTea();
        }

        private void labelDateBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
