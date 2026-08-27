using App.BL.Data.DbModels;

namespace App.BL.Data.Repositories
{
    public class TeaRepository : BaseRepository<TeaDbModel>
    {
        public TeaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}