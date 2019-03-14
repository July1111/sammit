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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            for (int i = 0; i < Service.SelectSummit().Length; i++)
            {
                //comboBoxSummit.Items.Add(Service.SelectSummit()[i].Summit_ID);
                comboBoxSummit.Items.Add(Service.SelectSummit()[i].Name);
            }
        }

        private void butMyVariant_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        private void ComboBoxCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*if (comboBoxSummit.Text != "")
            {
                ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();

            }*/
        }
    }
}
