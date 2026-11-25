using App.BL.Data.DbModels;

namespace App.BL.Data.Repositories
{
    public class UserRepository : BaseRepository<UserDbModel>
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        /// <summary>
        /// Получить пользователя по имени.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <returns>Пользователь</returns>
        public UserDbModel? GetUserByName(string name)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Name == name);
        }

        /// <summary>
        /// Получить пользователя по логину и паролю.
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Пользователь</returns>
        public UserDbModel? GetUserByNameAndPassword(string login, string password)
        {
            var user = _appDbContext.Users.FirstOrDefault(u => u.Name == login);

            if (BCrypt.Net.BCrypt.Verify(password, user?.Password))
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
