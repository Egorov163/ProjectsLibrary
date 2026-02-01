using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
using System.Collections.Generic;

namespace App.BL.Services
{
    public class UserService
    {
        /// <summary>
        /// Репозитории.
        /// </summary>
        private readonly UserRepository userRepository;

        /// <summary>
        /// Создать сервис Пользователи.
        /// </summary>
        /// <param name="userRepository"></param>
        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Добавить пользователя.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="password">Пароль</param>
        public void AddUser(string name, string password)
        {
            var user = new UserDbModel()
            {
                Name = name,
                //Password = password

                Password = BCrypt.Net.BCrypt.HashPassword(password)
        };

            userRepository.Add(user);
        }

        /// <summary>
        /// Удалить пользователя.
        /// </summary>
        /// <param name="id">id пользователя.</param>
        public void RemoveUser(int id)
        {
            var user = userRepository.Remove(id);
        }

        /// <summary>
        /// Получить список всех пользователей.
        /// </summary>
        /// <returns>Список пользователей</returns>
        public List<UserDbModel> GetAllUsers()
        {
            return userRepository.GetAll();
        }
    }
}
