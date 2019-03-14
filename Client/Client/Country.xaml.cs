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
    /// Логика взаимодействия для Country.xaml
    /// </summary>
    public partial class Country : Page
    {
        public Country()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Country Service1 = new ServiceReference1.Country();
            Service1.Name = Convert.ToString(textBox.Text);

            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            Service.AddCountry(Service1.Name);
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        private void ButCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }
    }
}
