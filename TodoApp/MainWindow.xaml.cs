using System.Windows;
using System.Windows.Controls;

namespace TodoApp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var container = new StackPanel() { Orientation = Orientation.Horizontal};
            var txtBox = new TextBox() { Text=txtEntriy.Text };
            var editBtn = new Button() { Content = "Edit" };
            var deleteBtn = new Button() { Content = "Delete"};
            deleteBtn.Click += DeleteBtn_Click;
            container.Children.Add(txtBox);
            container.Children.Add(editBtn);
            container.Children.Add(deleteBtn);
            lvEntries.Items.Add(container);
            txtEntriy.Clear();

        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if(button != null) 
            {
                var container = button.Parent as StackPanel;
                if(container != null)
                {
                    lvEntries.Items.Remove(container);
                }
            }
           
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();

        }

    }
}