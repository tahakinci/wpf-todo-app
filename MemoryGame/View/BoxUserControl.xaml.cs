using MemoryGame.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MemoryGame.View
{
    /// <summary>
    /// Interaction logic for BoxUserControl.xaml
    /// </summary>
    public partial class BoxUserControl : UserControl
    {

        public Visibility isVisible
        {
            get { return (Visibility)GetValue(isVisibleProperty); }
            set { SetValue(isVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for isVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty isVisibleProperty =
            DependencyProperty.Register("isVisible", typeof(Visibility), typeof(BoxUserControl), new PropertyMetadata(default));




        public BoxModel BoxInfo { get; set; }

        
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(BoxUserControl), new PropertyMetadata(default));


        public string Diffuculty { get; set; }

        public BoxUserControl(string diffuculty)
        {
            InitializeComponent();
            DataContext = this;
            Diffuculty = diffuculty;
            isVisible = Visibility.Visible;
        }
        private async void Starter()
        {
            if (Diffuculty == "Easy") await Task.Delay(5000);
            else if (Diffuculty == "Medium") await Task.Delay(3000);
            else if(Diffuculty == "Hard") await Task.Delay(1000);
            isVisible = Visibility.Hidden;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Value = BoxInfo.OriginalValue;
            Starter();
        }

        private void UserControl_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var userControl = sender as BoxUserControl;
            if(userControl != null)
            ((StackPanel)userControl.Content).Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
