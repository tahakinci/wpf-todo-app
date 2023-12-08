using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    /// <summary>
    /// RemoveTodoCommand
    /// </summary>
    internal class RemoveTodoCommand : ICommand
    {
        private readonly IServiceProvider provider;

        public event EventHandler CanExecuteChanged;
        public RemoveTodoCommand(IServiceProvider provider) => this.provider = provider;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemTodoList.Remove(vm.SelectedTodoItem);
        }
    }
}