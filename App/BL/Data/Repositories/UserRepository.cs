using App.BL.Data.DbModels;

namespace App.BL.Data.Repositories
{
    public class UserRepository : BaseRepository<UserDbModel>
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
