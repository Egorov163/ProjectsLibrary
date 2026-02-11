using App.BL.Data.Tea;
using System.Security.Principal;

namespace App.BL.Data.DbModels
{
    /// <summary>
    /// Модель чая в базе данных.
    /// </summary>
    public class TeaDbModel : BaseDbModel
    {
        /// <summary>
        /// Пользователь.
        /// </summary>
        public UserDbModel User { get; set; }
        /// <summary>
        /// Название чая.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип чая.
        /// </summary>
        public TeaType Type { get; set; }
        /// <summary>
        /// Дата покупки.
        /// </summary>
        public DateTime? DateBuy { get; set; }
        /// <summary>
        /// Описание чая.
        /// </summary>
        public string? Description { get; set; }
    }
}