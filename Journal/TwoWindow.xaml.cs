using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Journal.Data;
using Journal.Helpers;
using System.Collections;
using System.Windows.Navigation;


namespace Journal
{

    public partial class TwoWindow : Window
    {

        public TwoWindow(string login, string password)
        {

            InitializeComponent();
            AppHelper.MainFrame = frmain;
            OpenMainPage( login, password);
            
        }
        void OpenMainPage(string login, string password)
        {
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                Teachers teacher = AppHelper.DbConnect.Teachers
                .Where(x => x.Login == login && x.Password == password)
                .FirstOrDefault();

                AppHelper.MainFrame.Navigate(new GlavPage(teacher));
            }
        }
    }
}
