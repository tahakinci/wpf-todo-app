using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    internal class AddProgressToTodoCommand : ICommand
    {
        private MainWindowViewModel vm;
        private IServiceProvider provider;

        public event EventHandler CanExecuteChanged;
        public AddProgressToTodoCommand(IServiceProvider provider) => this.provider = provider;
        public bool CanExecute(object parameter) => parameter != null;

        public void Execute(object parameter)
        {
            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemTodoList.Add(vm.SelectedTodoItem);
            vm.ItemProgressList.Remove(vm.SelectedTodoItem);
        }
    }
}
