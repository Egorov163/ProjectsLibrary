using App.BL.Contexts;
using App.BL.Data;
using App.BL.Data.Repositories;
using App.BL.Moduls;
using App.BL.Services;

namespace App
{
    /// <summary>
    /// Приложение.
    /// </summary>
    class App
    {
        // Модули.
        private readonly UserModul _userModul;

        private List<IModul> _modulsList;

        public App(UserModul userModul)
        {
            // Модули.
            _userModul = userModul;

            _modulsList = new List<IModul>
            {
                _userModul
            };
        }
        public void Start()
        {
            Console.WriteLine("Вас приветствует универсальное приложение Дяди Сани!");
            

                //ShowModulesList();

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
