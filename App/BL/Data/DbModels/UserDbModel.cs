namespace App.BL.Data.DbModels
{
    /// <summary>
    /// Модель пользователя в базе данных.
    /// </summary>
    public class UserDbModel : BaseDbModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
