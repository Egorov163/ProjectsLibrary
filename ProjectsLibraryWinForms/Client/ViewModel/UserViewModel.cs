using App.BL.Data.DbModels;

namespace ProjectsLibraryWinForms.Client.ViewModel
{
    /// <summary>
    /// ViewModel пользователя
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public int UserId { get; set; }

    }
}
