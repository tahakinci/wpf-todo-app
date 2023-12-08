using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    /// <summary>
    /// Yapılanı Bitti'ye taşır.
    /// </summary>
    class AddDoneToProgressCommand : ICommand
    {
        private readonly IServiceProvider provider;

        public event EventHandler CanExecuteChanged;
        public AddDoneToProgressCommand(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public bool CanExecute(object parameter) => parameter != null;

        public void Execute(object parameter)
        {
            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemProgressList.Add(vm.SelectedTodoItem);
            vm.ItemDoneList.Remove(vm.SelectedTodoItem);
        }
    }
}