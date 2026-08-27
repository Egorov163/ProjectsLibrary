using App.BL.Contexts;
using App.BL.Services;

namespace App.BL.Moduls
{
    /// <summary>
    /// Модуль Пользователи
    /// </summary>
    public class UserModul : IModul
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
                Console.WriteLine($"\n{ToString()}");

                Console.WriteLine(
                    "\n1 - создать пользователя" +
                    "\n2 - удалить пользователя" +
                    "\n3 - вывести пользователей" +
                    "\n4 - авторизация");

                Actions();

                Console.Clear();

                isExit = true;
            }
        }

        private void Actions()
        {
            var exit = false;

            while (!exit)
            {
                Console.WriteLine($"\nВыберите действие:");

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
                    case 4:
                        Authorization();
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

        /// <summary>
        /// Авторизация.
        /// </summary>
        private void Authorization()
        {
            var name = HelperService.RequestStringInput("Введите имя пользователя");
            var password = HelperService.RequestStringInput("Введите пароль");

            if (name is not null)
            {
                var user = _userService.GetUserByName(name);
                if (user is not null)
                {
                    _userContext.CurrentUser = user;
                    Console.WriteLine($"Вы вошли как {user.Name}.");
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный логин или пароль");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное имя или пароль.");
            }
        }

        /// <summary>
        /// Добавить пользователя.
        /// </summary>
        private void AddUser()
        {
            var name = HelperService.RequestStringInput("Введите имя пользователя");

            if (name is not null)
            {
                var password = HelperService.RequestStringInput("Введите пароль");

                if (password is not null)
                {
                    _userService.AddUser(name, password);
                    Console.WriteLine("Пользователь создан!");
                    _userContext.CurrentUser = _userService.GetUserByName(name);
                }
                else
                {
                    Console.WriteLine("Вы не ввели пароль");
                }
            }
            else
            {
                Console.WriteLine("Вы не ввели имя");
            }
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

            if (id is not null)
            {
                _userService.RemoveUser((int)id);
                Console.WriteLine("Пользователь удалён");
            }
        }




        public void CheckCurentUserView()
        {
            if (_userContext.IsAuthenticated())
            {
                Console.WriteLine($"Здравствуйте, {_userContext.CurrentUser.Name}\n");
            }
            else
            {
                Console.WriteLine("Вы не авторизованы.\n");
            }
        }

        public override string ToString()
        {
            return "Модуль: Пользователи";
        }
    }
}
