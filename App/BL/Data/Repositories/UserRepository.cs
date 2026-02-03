using App.BL.Data.DbModels;

namespace App.BL.Data.Repositories
{
    public class UserRepository : BaseRepository<UserDbModel>
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public UserDbModel? GetUserByName(string name)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Name == name);
        }

        public UserDbModel? GetUserByNameAndPassword(string login, string password)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Name == login && u.Password == password);
        }
    }
}
