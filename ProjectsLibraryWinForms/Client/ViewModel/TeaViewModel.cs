using App.BL.Data.DbModels;
using App.BL.Data.Tea;

namespace ProjectsLibraryWinForms.Client.ViewModel
{
    /// <summary>
    /// ViewModel чая
    /// </summary>
    public class TeaViewModel
    {
        /// <summary>
        /// Идентификатор чая
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Пользователь.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Название чая.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип чая.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Дата покупки.
        /// </summary>
        public DateOnly DateBuy { get; set; }

        /// <summary>
        /// Описание чая.
        /// </summary>
        public string? Description { get; set; }

    }
}
