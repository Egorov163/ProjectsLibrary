using App.BL.Data;
using App.BL.Data.Repositories;
using App.BL.Moduls;
using App.BL.Services;

namespace App
{
    /// <summary>
    /// Приложение.
    /// </summary>
    class App
    {
        // Контексты.
        private readonly AppDbContext appDbContext;
        // Репозитории.
        private readonly UserRepository userRepository;
        // Модули.
        private readonly UserModul userModul;

        public App()
        {
            // Контексты.
            appDbContext = new AppDbContext();
            // Репозитории.
            userRepository = new UserRepository(appDbContext);
            // Модули.
            userModul = new UserModul(userRepository);
    }
    public void Start()
    {
        userModul.Start();
    }
}
}
