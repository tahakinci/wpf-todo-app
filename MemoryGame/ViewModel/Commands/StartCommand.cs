using MemoryGame.Model;
using MemoryGame.View;
using System.Windows.Input;

namespace MemoryGame.ViewModel.Commands
{
    public class StartCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public SetupPageViewModel VM { get; set; }

        public StartCommand(SetupPageViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            var setModel = new SetupModel(VM.Level, VM.Difficulty);
            var window = new MainWindow(setModel);
            window.Show();
            VM.CloseAction();
        }
    }
}
