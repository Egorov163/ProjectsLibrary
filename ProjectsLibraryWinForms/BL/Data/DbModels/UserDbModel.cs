namespace App.BL.Data.DbModels
{
    /// <summary>
    /// Модель пользователя в базе данных.
    /// </summary>
    public class UserDbModel : BaseDbModel
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; set; }
    }
}
