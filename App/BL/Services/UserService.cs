using App.BL.Data.DbModels;
using App.BL.Data.Repositories;

namespace App.BL.Services
{
    public class UserService
    {
        /// <summary>
        /// Репозитории.
        /// </summary>
        private readonly UserRepository _userRepository;

        /// <summary>
        /// Создать сервис Пользователи.
        /// </summary>
        /// <param name="userRepository"></param>
        public UserService(UserRepository userRepository)
        {
            this._userRepository = userRepository;
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
                Password = BCrypt.Net.BCrypt.HashPassword(password)
            };

            _userRepository.Add(user);
        }

        public void AddUser(UserDbModel user)
        {
            var badPassword = user.Password;
            user.Password = BCrypt.Net.BCrypt.HashPassword(badPassword);

            _userRepository.Add(user);
        }

        /// <summary>
        /// Удалить пользователя.
        /// </summary>
        /// <param name="id">id пользователя.</param>
        public void RemoveUser(int id)
        {
            var user = _userRepository.Remove(id);
        }

        /// <summary>
        /// Получить список всех пользователей.
        /// </summary>
        /// <returns>Список пользователей</returns>
        public List<UserDbModel> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        /// <summary>
        /// Получить пользователя по имени
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns>Пользователь</returns>
        public UserDbModel? GetUserByName(string name)
        {
            return _userRepository.GetUserByName(name);
        }

        public UserDbModel? GetUser(UserDbModel user)
        {
            return _userRepository.GetUserByNameAndPassword(user.Name, user.Password);
        }
    }
}
