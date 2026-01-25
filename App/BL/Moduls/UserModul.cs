using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
using App.BL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BL.Moduls
{
    /// <summary>
    /// Модуль Пользователи
    /// </summary>
    class UserModul
    {
        // Репозитории.
        private readonly UserRepository userRepository;
        //Сервисы.
        private readonly UserService userService;

        /// <summary>
        /// Создать мудуль.
        /// </summary>
        /// <param name="userRepository">Репозиторий с пользоватлеями</param>
        public UserModul(UserRepository userRepository)
        {
            // Репозитории.
            this.userRepository = userRepository;
            //Сервисы.
            userService = new UserService(userRepository);
        }

        public void Start()
        {
            Console.WriteLine("Модуль: Пользователи");
            Console.WriteLine($"Выберите действие:" +
                "\n1 - создать пользователя" +
                "\n2 - удалить пользователя" +
                "\n3 - вывести пользователей" +
                "\n4 - выход");

            Actions();

        }

        private void Actions()
        {
            var exit = false;

            while (!exit)
            {
                var request = RequestUser();

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

            userService.AddUser(name, password);
            Console.WriteLine("Пользователь создан!");
        }

        /// <summary>
        /// Вывести всех пользователей.
        /// </summary>
        private void ShowAllUser()
        {
            var users = userService.GetAllUsers();

            foreach (var user in users)
            {
                Console.WriteLine($"Пользователь - {user.Name} id - {user.Id}");
            }
        }

        private void RemoveUser()
        {
            var id = RequestUser("Введи id пользователя, которого хочешь удалить");

            if (id > 0)
            {
                userService.RemoveUser(id);
                Console.WriteLine("Пользователь удалён");
            }
        }

        /// <summary>
        /// Запрашивает ответ у пользователя и проверяет на корректность, ответ должен быть int.
        /// </summary>
        /// <param name="RequestText">Текст к запросу.</param>
        /// <returns>int, если -1, то пользователь отказался вводить запрос.</returns>
        private int RequestUser(string RequestText = "")
        {
            Console.WriteLine(RequestText);
            string request;

            while (true)
            {
                request = Console.ReadLine();

                if (int.TryParse(request, out int result))
                {
                    return result;
                }
                else if (request == "q!")
                {
                    return -1;
                }

                Console.WriteLine("Некорректный запрос, попробуй ещё раз, если хотите выйти введите q!");
            }
        }
    }
}
