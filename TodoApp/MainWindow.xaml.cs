using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TodoApp
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<object>();   
            description = new ObservableCollection<string>();   
            InitializeComponent();
        }

        private ObservableCollection<object> entries;

        public ObservableCollection<object> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        private ObservableCollection<string> description;

        public ObservableCollection<string> Description
        {
            get { return description; }
            set { description = value; }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Description.Add(txtEntriy.Text);
            var container = new StackPanel() { Orientation = Orientation.Horizontal };
            var txtBox = new TextBox() { Text = (string)description.Last() };
            var editBtn = new Button() { Content = "Edit" };
            var deleteBtn = new Button() { Content = "Delete" };
            container.Children.Add(txtBox);
            container.Children.Add(editBtn);
            container.Children.Add(deleteBtn);
            deleteBtn.Click += DeleteBtn_Click;
            Entries.Add(container);
            txtEntriy.Clear();
            


        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

            var button = sender as Button;
            if (button != null)
            {
                var container = button.Parent as StackPanel;
                if (container != null)
                {
                    TextBox txtBox = (TextBox)container.Children[0];
                    Description.Remove(txtBox.Text);
                    Entries.Remove(container);
              
                }
            }

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Description.Clear();
            Entries.Clear();
            
        }

        private void ListViewItem_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}