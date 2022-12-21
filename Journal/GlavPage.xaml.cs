using Journal.Data;
using Journal.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Journal
{
    /// <summary>
    /// Логика взаимодействия для GlavPage.xaml
    /// </summary>
    public partial class GlavPage : Page
    {

         object students;
        Teachers _teacher;

        public GlavPage(Teachers teacher)
        {
            InitializeComponent();

            _teacher = teacher;

            tbx_priv.Text = "Добро пожаловать!"+" "+teacher.Name + " " + teacher.FirstName;

            var currentClass = AppHelper.DbConnect.Class
                .Where(x => x.TeacherId == _teacher.Id).FirstOrDefault();
            if (currentClass == null)
            {
                MessageBox.Show("Учитель не привязан к классу");
                return;
            }
            students = AppHelper.DbConnect.StudentClass.ToList();

            lw_table.ItemsSource = students as IEnumerable;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.MainFrame.Navigate(new AddStudent());
        }

        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            lw_table.ItemsSource = students as IEnumerable;
        }
    }
}
