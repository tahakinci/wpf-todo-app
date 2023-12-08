using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    internal class ClearAllCommand : ICommand
    {
        private IServiceProvider provider;

        public event EventHandler CanExecuteChanged;
        public ClearAllCommand(IServiceProvider provider) => this.provider = provider;
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemTodoList.Clear();
            vm.ItemProgressList.Clear();
            vm.ItemDoneList.Clear();
        }
    }
}
