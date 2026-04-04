using App.BL.Moduls;
using App.BL.Services;

namespace App
{
    /// <summary>
    /// Приложение.
    /// </summary>
    class App
    {
        /// <summary>
        /// Список модулей.
        /// </summary>
        private List<IModul> _modulsList;

        // Пользователи
        private readonly UserModul _userModul;

        // Чай
        private readonly TeaModul _teaModul;

        public App(UserModul userModul, TeaModul teaModul)
        {
            _userModul = userModul;
            _teaModul = teaModul;

            _modulsList = new List<IModul>
            {
                // Модули.
                userModul,
                teaModul
            };
        }

        /// <summary>
        /// Запуск приложения.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Вас приветствует универсальное приложение Дяди Сани!\n");
            PickModul();
        }

        private void ShowModulesList()
        {
            for (int i = 0; i < _modulsList.Count; i++)
            {
                Console.WriteLine($"{_modulsList[i].ToString()} - {i}");
            }
        }

        /// <summary>
        /// Выбор модуля.
        /// </summary>
        /// <param name="modulsList">Список модулей</param>
        private void PickModul()
        {
            while (true)
            {
                _userModul.CheckCurentUserView();

                ShowModulesList();

                Console.WriteLine("Выберите модуль:");
                var request = HelperService.RequestIntInput();

                if (request is null)
                {
                    Environment.Exit(0);
                }
                else if (request >= 0 && (_modulsList.Count - 1) >= request)
                {
                    var modul = _modulsList[(int)request];
                    modul.Start();
                }
                else
                {
                    Console.WriteLine("Введите корректный запрос.");
                }
            }
        }
    }
}
