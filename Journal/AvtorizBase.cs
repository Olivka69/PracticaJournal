using System;
using System.Windows;

namespace Journal
{
    public static class AvtorizBase
    {
        public static bool testavtoriz(object user)
        {
            if (user == null)
            {
                MessageBox.Show("Ошибка! \n Неверный логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Вы вошли в систему", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }

        }

        internal static void testavtoriz()
        {
            throw new NotImplementedException();
        }
    }
}