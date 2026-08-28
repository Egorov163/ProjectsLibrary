using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
using ProjectsLibraryWinForms.Client.ViewModel;

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
        /// <returns>True - добавлен. False - некорректные данные</returns>
        public bool AddUser(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            var user = new UserDbModel()
            {
                Name = name,
                Password = BCrypt.Net.BCrypt.HashPassword(password)
            };

            _userRepository.Add(user);
            return true;
        }

        /// <summary>
        /// Добавить пользователя
        /// </summary>
        /// <param name="user">Имя</param>
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
        /// Маппер из бд во вью модель.
        /// </summary>
        /// <returns>Список пользователей</returns>
        public List<UserViewModel> UserMapper(List<UserDbModel> userDbModels)
        {
            var users = userDbModels.
                Select(u => new UserViewModel()
                {
                    Name = u.Name,
                    UserId = u.Id,
                }).
                ToList();

            return users;
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

    }
}
