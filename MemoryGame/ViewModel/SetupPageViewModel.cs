using MemoryGame.Model;
using MemoryGame.ViewModel.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace MemoryGame.ViewModel
{
    public class SetupPageViewModel :INotifyPropertyChanged
    {
        public SetupPageViewModel()
        {
            Difficulty = "Medium";
            Level = 1;
            StartCommand = new StartCommand(this);
        }
        private string diffuculty;

        public string Difficulty
        {
            get { return diffuculty; }
            set {
                diffuculty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Difficulty)));
            }
        }
        private int level;

        public int Level
        {
            get { return level; }
            set {
                level = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Level)));
            }
        }


        public event EventHandler? CanExecuteChanged;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand StartCommand { get; }
        public Action CloseAction { get; set; }
    }

  
}
