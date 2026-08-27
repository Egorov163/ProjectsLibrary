using App.BL.Data;
using App.BL.Data.Repositories;
using App.BL.Services;
using Microsoft.Extensions.DependencyInjection;
using ProjectsLibraryWinForms.Forms.Users;

namespace ProjectsLibraryWinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. НАСТРОЙКА: Регистрируем все зависимости
            var services = new ServiceCollection();

            // Регистрируем контексты
            services.AddDbContext<AppDbContext>();

            // Регистрируем репозитории
            services.AddScoped<UserRepository>();
            services.AddScoped<TeaRepository>();

            // Регистрируем сервисы
            services.AddScoped<UserService>();
            services.AddScoped<TeaService>();

            // Регистрируем все формы, которые будут использовать DI
            services.AddScoped<MainForm>();
            services.AddScoped<ListUsersForm>();

            // Строим провайдер сервисов
            var ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}