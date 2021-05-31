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

using oop.model;
using oop.repository;

namespace grprj_01_02_01_Ember_Tanar_Diak_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SchoolCitizens sc;

        public MainWindow()
        {
            sc = new SchoolCitizens();
            this.DataContext = sc;

            InitializeComponent();
            lvStudents.ItemsSource = sc.GetStudents();
        }

        private void btStatistics_Click(object sender, RoutedEventArgs e)
        {
            tbNumberOfSelectedStudent.Text = sc.SelectedStudentNumber + " fő.";
            tbAvarageOfSelectedStudent.Text = Math.Round(sc.SelectedStudentAvarageOfGradePointAvarage,2).ToString();
        }
    }
}
