using Microsoft.Extensions.DependencyInjection;
using TodoApp.Commands;
using TodoApp.ViewModel;

namespace TodoApp
{
    internal static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<ItemViewModel>();
            services.AddSingleton<MainWindowViewModel>();

            services.AddTransient<MainWindow>();

            services.AddTransient<RemoveTodoCommand>();

            services.AddTransient<AddNewItemCommand>();
            services.AddTransient<AddToProgressCommand>();
            services.AddTransient<AddToDoneCommand>();
            services.AddTransient<AddDoneToProgressCommand>();
            services.AddTransient<AddProgressToTodoCommand>();
            services.AddTransient<ClearAllCommand>();

        }
    }
}