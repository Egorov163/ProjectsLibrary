using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
using ProjectsLibraryWinForms.Client.ViewModel;

namespace App.BL.Services
{
    public class TeaService
    {
        /// <summary>
        /// Репозитории.
        /// </summary>
        private readonly TeaRepository _teaRepository;

        /// <summary>
        /// Создать сервис по Чаю.
        /// </summary>
        /// <param name="teaRepository"></param>
        public TeaService(TeaRepository teaRepository)
        {
            _teaRepository = teaRepository;
        }

        /// <summary>
        /// Получить список всего чая.
        /// </summary>
        /// <returns>Список чая</returns>
        public List<TeaDbModel> GetAllTea()
        {
            return _teaRepository.GetAll();
        }

        /// <summary>
        /// Маппер из бд во вью модель.
        /// </summary>
        /// <returns>Список чая</returns>
        public List<TeaViewModel> TeaMapper(List<TeaDbModel> teaDbModels)
        {
            var users = teaDbModels.
                Select(t => new TeaViewModel()
                {
                    Id = t.Id,
                    DateBuy = t.DateBuy,
                    Description = t.Description,
                    Name = t.Name,
                    Type = t.Type,
                    User = t.User.Name
                }).
                ToList();

            return users;
        }

        /// <summary>
        /// Добавить чай.
        /// </summary>
        /// <param name="teaDbModel"></param>
        public void AddTea(TeaDbModel teaDbModel)
        {
            _teaRepository.Add(teaDbModel);
        }

        /// <summary>
        /// Удалить чай.
        /// </summary>
        /// <param name="id">id чая.</param>
        public void RemoveTea(int id)
        {
            var user = _teaRepository.Remove(id);
        }
    }
}