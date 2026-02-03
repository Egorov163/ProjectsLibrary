using App.BL.Contexts;
using App.BL.Data.Repositories;
using App.BL.Services;
using System;

namespace App.BL.Moduls
{
    /// <summary>
    /// Модуль Пользователи
    /// </summary>
    class UserModul : IModul
    {
        // Контексты.
        private readonly UserContext _userContext;
        // Сервисы.
        private readonly UserService _userService;

        /// <summary>
        /// Создать мудуль.
        /// </summary>
        /// <param name="userRepository">Репозиторий с пользоватлеями</param>
        public UserModul(UserContext userContext, UserService userService)
        {
            // Контексты.
            _userContext = userContext;
            // Сервисы.
            _userService = userService;
        }

        public void Start()
        {
            var isExit = false;

            while (!isExit)
            {
                Console.WriteLine("Модуль: Пользователи\n");

                CheckCurentUserView();

                Console.WriteLine($"\nВыберите действие:" +
                    "\n1 - создать пользователя" +
                    "\n2 - удалить пользователя" +
                    "\n3 - вывести пользователей" +
                    "\n4 - выход");

                Actions();

                isExit = true;
            }

            Console.Clear();
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
                        AddUser();
                        break;
                    case 2:
                        RemoveUser();
                        break;
                    case 3:
                        ShowAllUser();
                        break;
                    case -1:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Введите запрос повторно");
                        break;
                }
            }
        }

        /// <summary>
        /// Добавить пользователя.
        /// </summary>
        private void AddUser()
        {
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            var password = Console.ReadLine();

            _userService.AddUser(name, password);
            Console.WriteLine("Пользователь создан!");

            _userContext.CurrentUser = _userService.GetUserByName(name);
        }

        /// <summary>
        /// Вывести всех пользователей.
        /// </summary>
        private void ShowAllUser()
        {
            var users = _userService.GetAllUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"Пользователь - {user.Name} id - {user.Id}");
            }
        }

        /// <summary>
        /// Удалить пользователя.
        /// </summary>
        private void RemoveUser()
        {
            var id = HelperService.RequestIntInput("Введи id пользователя, которого хочешь удалить");

            if (id > 0)
            {
                _userService.RemoveUser(id);
                Console.WriteLine("Пользователь удалён");
            }
        }

        


        private void CheckCurentUserView()
        {
            if (_userContext.IsAuthenticated())
            {
                Console.WriteLine($"Здравствуйте, {_userContext.CurrentUser}");
            }
            else
            {
                Console.WriteLine("Вы не авторизованы.");
            }
        }

        public override string ToString()
        {
            return "Модуль: Пользователи";
        }
    }
}
