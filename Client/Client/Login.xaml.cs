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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public static bool flag;
        public static int UserID;

        public Login()
        {
            InitializeComponent();
        }

        private void butEnter_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            if (Service.Authorisation(Convert.ToString(textBoxLogin.Text), Convert.ToString(Password.Password)).id_user == 8)
            {
                UserID = Service.Authorisation(Convert.ToString(textBoxLogin.Text), Convert.ToString(Password.Password)).id_user;
                NavigationService.Navigate(new Uri("/Admin.xaml", UriKind.Relative));
                Properties.Settings.Default.User_ID = UserID;
                Properties.Settings.Default.Save();
            }

            else if (Service.Authorisation(Convert.ToString(textBoxLogin.Text), Convert.ToString(Password.Password)).id_user != 8 && Service.Authorisation(Convert.ToString(textBoxLogin.Text), Convert.ToString(Password.Password)).id_user != 0)
            {
                UserID = Service.Authorisation(Convert.ToString(textBoxLogin.Text), Convert.ToString(Password.Password)).id_user;
                NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
                Properties.Settings.Default.User_ID = UserID;
                Properties.Settings.Default.Save();
            }

            else
            {
                MessageBox.Show("Ошибка в паре логин/пароль!");
            }
        }
    }
}
