using MemoryGame.Model;
using MemoryGame.View;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BoxUserControl BoxElement;
        public BoxModel Box { get; set; }
        public int Level { get; set; }
        public List<List<int>> LocationList { get; set; }
        public int Clicks { get; set; }
        public List<bool> Guesses { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LocationList = new List<List<int>>();
            Guesses = new List<bool>();
            Clicks = 1;
            Level = 4;
            deneme();
           
        }
        private void deneme()
        {
            for (int i = 1; i <= Level; i++)
            {
            Generate:
                var myList = GenerateRandomList();
                BoxElement = new BoxUserControl();
                bool deneme = LocationList.Any(l => l.SequenceEqual(myList));
                if (!deneme)
                {
                    container.Children.Add(BoxElement);
                    BoxElement.BoxInfo = new BoxModel(i, myList, i);
                    LocationList.Add(myList);
                }
                else goto Generate;
                Grid.SetColumn(BoxElement, myList[0]);
                Grid.SetRow(BoxElement, myList[1]);
            }
        }
        private List<int> GenerateRandomList()
        {
            int Column = new Random().Next(0, 12);
            int Row = new Random().Next(0, 6);
            return new List<int>() {Column, Row};
        }
        private void GameOver(bool isFailed)
        {
            if(isFailed)
            {
                 var gameOverDialog = new GameOverDialog();
                gameOverDialog.Owner = this;
                gameOverDialog.Show();
                return;

            }
            MessageBox.Show("You Win");

        }

        private void container_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var value = ((BoxUserControl)e.Source).BoxInfo.OriginalValue == Clicks;
            Guesses.Add(value);
            if(Clicks == Level) 
            {
                var result = Guesses.Any(r => r == false);
                GameOver(result);

            }
            Clicks++;
        }

    }
}