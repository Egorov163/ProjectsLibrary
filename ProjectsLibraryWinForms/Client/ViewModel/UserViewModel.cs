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
        /// Идентификатор пользователя
        /// </summary>
        public int Id { get; set; }
    }
}
