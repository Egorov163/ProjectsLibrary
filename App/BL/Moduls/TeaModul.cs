
using App.BL.Contexts;
using App.BL.Data.DbModels;
using App.BL.Data.Tea;
using App.BL.Services;

namespace App.BL.Moduls
{
    public class TeaModul : IModul
    {
        // Контексты.
        private readonly UserContext _userContext;
        // Сервисы.
        private readonly TeaService _teaService;

        public TeaModul(UserContext userContext, TeaService teaService)
        {
            _userContext = userContext;
            _teaService = teaService;
        }

        public void Start()
        {
            var isExit = false;

            if (_userContext.IsAuthenticated())
            {
                while (!isExit)
                {
                    Console.WriteLine($"\n{ToString()}");

                    Console.WriteLine($"\nВыберите действие:" +
                        "\n1 - добавить чай" +
                        "\n2 - удалить чай" +
                        "\n3 - вывести чай");

                    Actions();

                    Console.Clear();

                    isExit = true;
                }
            }
            else
            {
                Console.WriteLine("Нужно авторизоваться");
            }
        }

        private void Actions()
        {
            var exit = false;

            while (!exit)
            {
                var request = HelperService.RequestIntInput();

                switch (request)
                {
                    case 1:
                        AddTea();
                        break;
                    case 2:
                        RemoveTea();
                        break;
                    case 3:
                        ShowAllTea();
                        break;
                    case null:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Введите запрос повторно");
                        break;
                }
            }
        }

        public override string ToString()
        {
            return "Модуль: Чай";
        }

        private void ShowAllTea()
        {
            throw new NotImplementedException();
        }

        private void RemoveTea()
        {
            throw new NotImplementedException();
        }

        private void AddTea()
        {

            var teaName = HelperService.RequestStringInput("Введите название чая");

            if (teaName is not null)
            {
                var teaType = HelperService.RequestEnumInput<TeaType>("Выберите тип чая");

                if (teaType is not null)
                {
                    var dateBuy = HelperService.RequestDateTimeInput("Введите дату покупки, в формате dd.mm.yyyy");
                    var description = HelperService.RequestStringInput("Введите описание чая");

                    var tea = new TeaDbModel()
                    {
                        User = _userContext.CurrentUser,
                        Name = teaName,
                        Description = description,
                        Type = (TeaType)teaType,
                        DateBuy = dateBuy
                    };

                    _teaService.AddTea(tea);
                }
            }
        }
    }
}
