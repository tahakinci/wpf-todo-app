using MemoryGame.ViewModel;
using System.Windows;

namespace MemoryGame.View
{
    public partial class SetupPage : Window
    {
        public SetupPage()
        {
            InitializeComponent();
            VM = new SetupPageViewModel();
            DataContext = VM;
            VM.CloseAction = new Action(Close);
        }
        public SetupPageViewModel VM { get; set; }
    }
}
