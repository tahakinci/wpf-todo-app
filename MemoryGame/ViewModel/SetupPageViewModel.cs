using CommunityToolkit.Mvvm.Input;
using MemoryGame.Domain;
using MemoryGame;
using System.ComponentModel;
using System.Windows.Input;

namespace MemoryGame.ViewModel
{
    public class SetupPageViewModel 
    {
        public GameManager GameManager { get; set; }
        public int DelayTime { get; set; }
        public ICommand StartCommand { get; set; }
        public SetupPageViewModel()
        {
            Difficulty = "Medium";
            Level = 1;
            GameManager = new GameManager();
            StartCommand = new RelayCommand(ExecuteStartCommand);
        }
        private string diffuculty;

        public string Difficulty
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

        public void ExecuteStartCommand()
        {

            if (Difficulty == "Easy") DelayTime = 3000;
            else if (Difficulty == "Medium") DelayTime = 2000;
            else if (Difficulty == "Hard") DelayTime = 1000;
            GameManager.StartRound(Level, DelayTime);
            new MainPageViewModel(GameManager);
            new MainWindow(GameManager).Show();
        }
        public event EventHandler? CanExecuteChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Action CloseAction { get; set; }
    }


}
