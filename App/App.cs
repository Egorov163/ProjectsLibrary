using App.BL.Contexts;
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
        // Модули.
        private readonly UserModul _userModul;

        public App(UserModul userModul)
        {
            // Модули.
            _userModul = userModul;
        }
        public void Start()
        {
            _userModul.Start();
        }
    }
}
