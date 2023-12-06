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
            todo = new List<object>();
            inProgress = new ObservableCollection<object>();
            done = new ObservableCollection<object>();
            InitializeComponent();
        }

        private ObservableCollection<List<object>> data;

        public ObservableCollection<List<object>> Data
        {
            get { return data; }
            set { data = value; }
        }


        private ObservableCollection<object> inProgress;

        public ObservableCollection<object> InProgress
        {
            get { return inProgress; }
            set { inProgress = value; }
        }

        private ObservableCollection<object> done;

        public ObservableCollection<object> Done
        {
            get { return done; }
            set { done = value; }
        }



        private List<object> todo;

        public List<object> Todo 
        {
            get { return todo; }
            set { todo = value; }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var container = new StackPanel() { Orientation = Orientation.Horizontal };
            var txtBox = new TextBox() { Text = txtEntriy.Text };
            var editBtn = new Button() { Content = "Edit" };
            var deleteBtn = new Button() { Content = "Delete" };
            container.Children.Add(txtBox);
            container.Children.Add(editBtn);
            container.Children.Add(deleteBtn);
            deleteBtn.Click += DeleteBtn_Click;
            Todo.Add(container);
            TextBox field = (TextBox)container.Children[0];
            Todo.Add(field.Text);
            Data.Add(todo);
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
                    //data.Remove(txtBox.Text);
                    Todo.Remove(container);
              
                }
            }

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //data.Clear();
            Todo.Clear();
            
        }

        private void btnPostRight_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = todoList.SelectedItem;
            todo.Remove(selectedItem);
            inProgress.Add(selectedItem);
        }

        private void btnPostLeft_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = inProgressList.SelectedItem;
            inProgress.Remove(selectedItem);
            todo.Add(selectedItem);
        }
    }
}