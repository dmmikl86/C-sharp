using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private int _index;

        public int Index
        {
            get { return _index; }
            set
            {
                if (value > students.Count - 1)
                {
                    _index = 0;
                }
                else if (value < 0)
                {
                    _index = students.Count - 1;
                }
                else
                {
                    _index = value;
                }
            }
        }

        public Student this[int index]
        {
            get { return students[index]; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text));
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Student student = students[Index];
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
            Index++;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Student student = students[Index];
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
            Index--;
        }
    }
}