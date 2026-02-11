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
        private readonly UserModul _userModul;
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

                if (request >= 0 && (_modulsList.Count - 1) >= request)
                {
                    var modul = _modulsList[request];
                    modul.Start();
                }
                else if (request == -1)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Введите корректный запрос.");
                }
            }
        }
    }
}
