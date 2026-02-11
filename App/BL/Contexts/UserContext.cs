using App.BL.Data.DbModels;

namespace App.BL.Contexts
{
    public class UserContext
    {
        /// <summary>
        /// Текущий пользователь.
        /// </summary>
        public UserDbModel? CurrentUser;

        /// <summary>
        /// Проверить, авторизован ли пользователь.
        /// </summary>
        public bool IsAuthenticated()
        {
            return CurrentUser != null;
        }
    }
}
