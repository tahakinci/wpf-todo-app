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
        private BoxUserControl Box;
        public List<List<int>> LocationList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LocationList = new List<List<int>>();
            deneme();
           
        }
        private void deneme()
        {
            for (int i = 0; i < 10; i++) 
            {
                Generate:
                var myList = GenerateRandomList();
                Box = new BoxUserControl();
                container.Children.Add(Box);
                bool deneme = LocationList.Any(l => l.SequenceEqual(myList));
                if (!deneme) LocationList.Add(myList);
                else goto Generate;
                Grid.SetColumn(Box, myList[0]);
                Grid.SetRow(Box, myList[1]);
            }
        }
        private List<int> GenerateRandomList()
        {
            int Column = new Random().Next(0, 12);
            int Row = new Random().Next(0, 6);
            return new List<int>() {Column, Row};
        }
    }
}