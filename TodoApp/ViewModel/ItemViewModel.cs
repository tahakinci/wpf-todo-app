using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using TodoApp.Commands;

namespace TodoApp.ViewModel
{
    internal class ItemViewModel
    {
        public ICommand RemoveTodoCommand { get; }

        public string Message { get; set; }

        public ItemViewModel(IServiceProvider provider)
        {
            RemoveTodoCommand = provider.GetService<RemoveTodoCommand>();
        }
    }
}
