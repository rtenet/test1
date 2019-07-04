using System;
using MVVMDemo.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace MVVMDemo.ViewModel
{

    public class StudentViewModel
    {

        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {

            ObservableCollection<Student> students = new ObservableCollection<Student>();
            Student s1 = new Student();
            //s1.PropertyChanged += s1_PropertyChanged;
            s1.FirstName = "Mark";
            s1.LastName = "Allain";
            students.Add(s1);
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }

        void s1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            MessageBox.Show(e.PropertyName + " added");
        }

        public void Print()
        {
            Console.WriteLine("test");
        }
    }
}