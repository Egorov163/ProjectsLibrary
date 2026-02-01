using App.BL.Data.DbModels;

namespace App.BL.Data.Repositories
{
    public class UserRepository : BaseRepository<UserDbModel>
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public UserDbModel? GetByName(string name)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Name == name);
        }
    }
}
