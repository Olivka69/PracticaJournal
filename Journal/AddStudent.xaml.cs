using Journal.Data;
using Journal.Helpers;
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
using System.Data.Entity;
using Journal;
using System.Globalization;

namespace Journal
{
    /// <summary>
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {
        public AddStudent()
        {
            InitializeComponent();


        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Students student = new Students();
                student.Name = tbx_st_name.Text;
                student.FirstName = tbx_st_fname.Text;
                student.Patronymic = tbx_st_lname.Text;
                student.PhoneNum = ProverkaBox.ValidTextBox(tbx_st_phone.Text);
                student.PassportNumber = ProverkaBox.ValidTextBox(tbx_numpas.Text);
                student.BirthDate = Convert.ToDateTime(Convert.ToInt32(tbx_dr.Text));
                student.PassportDepartmentInfo = tbx_pasport.Text;
                student.SNILS = ProverkaBox.ValidTextBox(tbx_snils.Text);
                student.INN = ProverkaBox.ValidTextBox(tbx_inn.Text);
                student.DiplomaNumber = ProverkaBox.ValidTextBox(tbx_attectat.Text);

                AppHelper.DbConnect.Students.Add(student);
                AppHelper.DbConnect.SaveChangesAsync();
                MessageBox.Show("Данные сохранены", "Данные сохранены", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            AppHelper.MainFrame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentClass klass = new StudentClass();
            klass.ClassId = Convert.ToInt32(tbx_classid.Text);
            klass.StudentId = Convert.ToInt32(tbx_studentid.Text);
            AppHelper.DbConnect.StudentClass.Add(klass);
            AppHelper.DbConnect.SaveChangesAsync();
            MessageBox.Show("Данные сохранены", "Данные сохранены", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
