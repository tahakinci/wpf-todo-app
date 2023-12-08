using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;
using TodoApp.ViewModel;

namespace TodoApp.UserControls
{
    /// <summary>
    /// Item için özel kontrol
    /// </summary>
    public partial class ItemUserControl : UserControl
    {
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }
        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(ItemUserControl), new PropertyMetadata(default));

        public ItemUserControl()
        {
            //DataContext = new ItemViewModel()
            InitializeComponent();
        }
    }
}