using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    /// <summary>
    /// Seçili task i yapılanlara taşır.
    /// </summary>
    class AddToProgressCommand : ICommand
    {
        private readonly IServiceProvider provider;

        public event EventHandler CanExecuteChanged;
        public AddToProgressCommand(IServiceProvider provider) => this.provider = provider;

        public bool CanExecute(object parameter) => parameter!=null;
        public void Execute(object parameter)
        {
            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemProgressList.Add(vm.SelectedTodoItem);
            vm.ItemTodoList.Remove(vm.SelectedTodoItem);
        }
    }
}