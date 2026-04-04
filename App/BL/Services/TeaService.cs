using App.BL.Data.DbModels;
using App.BL.Data.Repositories;
using App.BL.Data.Tea;

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

        public void AddTea(TeaDbModel teaDbModel)
        {
            _teaRepository.Add(teaDbModel);
        }
    }
}