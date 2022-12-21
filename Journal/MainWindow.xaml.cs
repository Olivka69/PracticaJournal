using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Journal.Helpers;
using System.Text.RegularExpressions;
using JournalLibrary;

namespace Journal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz.ValidLogin(tbx_log.Text);

            var user = AppHelper.DbConnect.Teachers
                .Where(x => x.Login == tbx_log.Text && x.Password == tbx_pas.Password)
                .FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Ошибка! \n Неверный логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Вы вошли в систему", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            TwoWindow oknotwo = new TwoWindow(tbx_log.Text, tbx_pas.Password);
            oknotwo.Show();
        }

    }
}
