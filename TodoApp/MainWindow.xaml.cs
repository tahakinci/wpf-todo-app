using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TodoApp
{
    public class TodoData
    {

        public StackPanel Container { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }    
        public TodoData(StackPanel container, string status, int id)
        {
            this.Container = container;
            this.Status = status;
            this.Id = id;
        }
    }

    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            DataContext = this;
            todo = new ObservableCollection<object>();
            inProgress = new ObservableCollection<object>();
            done = new ObservableCollection<object>();
            data = new List<TodoData>();
            InitializeComponent();
        }

        int id = 0;

        private List<TodoData> data;

        public List<TodoData> Data
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



        private ObservableCollection<object> todo;

        public ObservableCollection<object> Todo 
        {
            get { return todo; }
            set { todo = value; }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var container = new StackPanel() { Orientation = Orientation.Horizontal, Name=$"container{id}"};
            var txtBox = new TextBox() { Text = txtEntriy.Text };
            var editBtn = new Button() { Content = "Edit" };
            var deleteBtn = new Button() { Content = "Delete" };
            container.Children.Add(txtBox);
            container.Children.Add(editBtn);
            container.Children.Add(deleteBtn);
            deleteBtn.Click += DeleteBtn_Click;
            TextBox field = (TextBox)container.Children[0];
            TodoData todoItem = new TodoData(container, "Todo", id++);
            data.Add(todoItem);
            Todo.Add(todoItem.Container);
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
                var item = data.FirstOrDefault(x => x.Container.Name == container.Name);

                    if (item != null)
                    {
                        data.Remove(item);

                        switch (item.Status)
                        {
                            case "Todo":
                                Todo.Remove(item);
                                break;
                            case "InProgress":
                                InProgress.Remove(item);
                                break;
                            case "Done":
                                Done.Remove(item);
                                break;
                            
                        }

                    }
                }
            }

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //data.Clear();
            Todo.Clear();
            
        }

        private void MoveItem(StackPanel selectedItem, ObservableCollection<object> sourceList, ObservableCollection<object> destinationList, string newStatus)
        {
            var item = data.FirstOrDefault(x => x.Container.Name == selectedItem.Name);

            sourceList.Remove(selectedItem);
            destinationList.Add(selectedItem);

            foreach (var todoItem in data.Where(x => x.Container.Name == item.Container.Name))
            {
                todoItem.Status = newStatus;
            }
        }

        private void btnPostRight_Click(object sender, RoutedEventArgs e)
        {
            if (todoList.SelectedItem != null)
            {
                MoveItem((StackPanel)todoList.SelectedItem, Todo, InProgress, "InProgress");
            }
            else if (inProgressList.SelectedItem != null)
            {
                MoveItem((StackPanel)inProgressList.SelectedItem, InProgress, Done, "Done");
            }

        }



        private void btnPostLeft_Click(object sender, RoutedEventArgs e)
        {
            if (inProgressList.SelectedItem != null)
            {
                MoveItem((StackPanel)inProgressList.SelectedItem, InProgress, Todo, "Todo");
            }
            else if (doneList.SelectedItem != null)
            {
                MoveItem((StackPanel)doneList.SelectedItem, Done, InProgress, "InProgress");
            }

        }
    }
}