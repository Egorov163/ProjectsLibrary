using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
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
        private UserRepository userRepository;

        /// <summary>
        /// Создать мудуль.
        /// </summary>
        /// <param name="userRepository">Репозиторий с пользоватлеями</param>
        public UserModul(UserRepository userRepository)
        {
            this.userRepository = userRepository;
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

            var user = new UserDbModel()
            {
                Name = name,
                Password = password
            };

            userRepository.Add(user);
            Console.WriteLine("\tПользователь создан!");
        }

        /// <summary>
        /// Вывести всех пользователей.
        /// </summary>
        private void ShowAllUser()
        {
            var users = userRepository.GetAll();

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
                userRepository.Remove(id);
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

            do
            {
                request = Console.ReadLine();

                if (int.TryParse(request, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Некорректный запрос, попробуй ещё раз, если хотите выйти введите q!");
                }
            } while (request != "q!");

            return -1;
        }
    }
}
