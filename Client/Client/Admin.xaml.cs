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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Butsummarize_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButdeleteAllVoises_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            MessageBoxResult result = MessageBox.Show("Удалить все голоса?", "Голоса",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Service.DeleteAllVoices();
            }
            else
            {

            }
        }

        private void ButaddSummit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Summit.xaml", UriKind.Relative));
        }

        private void ButOutput_Click(object sender, RoutedEventArgs e)
        {
            Login.UserID = 0;
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }
    }
}
