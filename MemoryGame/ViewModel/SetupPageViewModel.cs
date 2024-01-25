using CommunityToolkit.Mvvm.Input;
using MemoryGame.Domain;
using MemoryGame.Model;
using MemoryGame.ViewModel.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace MemoryGame.ViewModel
{
    public class SetupPageViewModel 
    {
        public GameManager GameManager { get; set; }

        //public ICommand StartCommand { get; set; }
        public SetupPageViewModel()
        {
            Difficulty = 2000;
            Level = 1;
            //StartCommand = new RelayCommand(ExecuteStartCommand);
        }
        private int diffuculty;

        public int Difficulty
        {
            get { return diffuculty; }
            set
            {
                diffuculty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Difficulty)));
            }
        }
        private int level;

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Level)));
            }
        }

        //public void ExecuteStartCommand ()
        //{
        //    var gameManager = new 
        //}
        public event EventHandler? CanExecuteChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Action CloseAction { get; set; }
    }


}
