using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.Model;
using TodoApp.ViewModel;

namespace TodoApp.Commands
{
    /// <summary>
    /// Ana listeye tast ekler.
    /// </summary>
    class AddNewItemCommand : ICommand
    {
        private readonly IServiceProvider provider;
        public event EventHandler CanExecuteChanged;
        public AddNewItemCommand(IServiceProvider provider) => this.provider = provider;

        public bool CanExecute(object parameter) => parameter != string.Empty;

        public void Execute(object parameter)
        {
            var newItem     = new ItemModel();
            newItem.Message = parameter.ToString();

            var vm = provider.GetService<MainWindowViewModel>();
            vm.ItemTodoList.Add(newItem);
        }
    }
}