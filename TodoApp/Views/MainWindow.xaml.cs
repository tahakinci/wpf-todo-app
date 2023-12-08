using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using TodoApp.ViewModel;

namespace TodoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow(IServiceProvider provider)
        {
            DataContext = provider.GetService<MainWindowViewModel>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}