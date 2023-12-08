using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TodoApp.Commands;
using TodoApp.Model;

namespace TodoApp.ViewModel
{
    /// <summary>
    /// MainWindow'a ait işlemleri yönetir.
    /// </summary>
    internal class MainWindowViewModel
    {
        public ICommand AddItemCommand { get; }
        public ICommand AddToProgressCommand { get; }
        public ICommand AddToDoneCommand { get; }
        public ICommand AddProgressToTodoCommand { get; }
        public ICommand AddDoneToProgressCommand { get; }
        public ICommand ClearAllCommand { get; }
        public ICommand RemoveTodoCommand { get; }

        public ObservableCollection<ItemModel> ItemTodoList { get; }     = [];
        public ObservableCollection<ItemModel> ItemProgressList { get; } = [];
        public ObservableCollection<ItemModel> ItemDoneList { get; }     = [];

        public ItemModel SelectedTodoItem { get; set; }

        public MainWindowViewModel(IServiceProvider provider)
        {
            AddItemCommand            = provider.GetService<AddNewItemCommand>();
            AddToProgressCommand      = provider.GetService<AddToProgressCommand>();
            AddToDoneCommand          = provider.GetService<AddToDoneCommand>();
            AddProgressToTodoCommand  = provider.GetService<AddProgressToTodoCommand>();
            AddDoneToProgressCommand  = provider.GetService<AddDoneToProgressCommand>();
            AddProgressToTodoCommand  = provider.GetService<AddProgressToTodoCommand>();
            ClearAllCommand           = provider.GetService<ClearAllCommand>();
        }
    }
}