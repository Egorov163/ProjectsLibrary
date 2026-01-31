using App.BL.Data.Repositories;
using App.BL.Moduls;
using App.BL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            // Репозитории
            services.AddScoped<UserRepository>();
            // Сервисы
            services.AddTransient<UserService>();
            // Модули
            services.AddTransient<UserModul>();
            // Приложение
            services.AddScoped<App>();

            var servicesProvider = services.BuildServiceProvider();

            var app = servicesProvider.GetRequiredService<App>();
            app.Start();

        }
    }
}
