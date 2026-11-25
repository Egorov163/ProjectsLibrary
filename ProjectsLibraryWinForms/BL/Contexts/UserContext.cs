using App.BL.Data.DbModels;
using Microsoft.VisualBasic.ApplicationServices;

namespace App.BL.Contexts
{
    public class UserContext
    {
        /// <summary>
        /// Текущий пользователь.
        /// </summary>
        public UserDbModel? CurrentUser { get; private set; }

        public event Action? UserChanged;

         /// <summary>
         /// Войти.
         /// </summary>
         /// <param name="user">Пользователь</param>
        public void SignIn(UserDbModel user)
        {
            CurrentUser = user;
            UserChanged?.Invoke();
        }

        /// <summary>
        /// Выйти.
        /// </summary>
        public void SignOut()
        {
            CurrentUser = null;
            UserChanged?.Invoke();
        }

        /// <summary>
        /// Проверить, авторизован ли пользователь.
        /// </summary>
        public bool IsAuthenticated()
        {
            return CurrentUser != null;
        }
    }
}
