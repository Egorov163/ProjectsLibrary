using App.BL.Contexts;
using App.BL.Data;
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

            // Контексты
            services.AddScoped<AppDbContext>();
            services.AddScoped<UserContext>();
            // Репозитории
            services.AddScoped<UserRepository>();
            services.AddScoped<TeaRepository>();
            // Сервисы
            services.AddTransient<UserService>();
            services.AddTransient<TeaService>();
            // Модули
            services.AddTransient<UserModul>();
            services.AddTransient<TeaModul>();
            // Приложение
            services.AddScoped<App>();

            var servicesProvider = services.BuildServiceProvider();

            var app = servicesProvider.GetRequiredService<App>();

            app.Start();
        }
    }
}
