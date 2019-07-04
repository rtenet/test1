using System.Windows;
using MVVMDemo.ViewModel;

namespace MVVMDemo1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            var obj = new StudentViewModel();
            var type = obj.GetType();
            var method = type.GetMethod("Print");
            method.Invoke(obj, null);
            StudentViewModel studentViewModelObject = new StudentViewModel();
            studentViewModelObject.LoadStudents();

            StudentViewControl.DataContext = studentViewModelObject;
        }
    }
}