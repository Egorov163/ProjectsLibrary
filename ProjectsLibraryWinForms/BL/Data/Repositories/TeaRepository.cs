using App.BL.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace App.BL.Data.Repositories
{
    public class TeaRepository : BaseRepository<TeaDbModel>
    {
        public TeaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public override List<TeaDbModel> GetAll()
        {
            return _entities
                .Include(t => t.User)
                .ToList();
        }
    }
}