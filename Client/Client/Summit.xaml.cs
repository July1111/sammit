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
    /// Логика взаимодействия для Summit.xaml
    /// </summary>
    public partial class Summit : Page
    {
        public Summit()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            if (textBox.Text != "" && StartDate.Text != "")
            {
                ServiceReference1.Summit summit = new ServiceReference1.Summit();
                summit.Date = Convert.ToDateTime(StartDate.SelectedDate);
                summit.Name = Convert.ToString(textBox.Text);

                Service.AddSummit(summit.Name,summit.Date);
                NavigationService.Navigate(new Uri("/Admin.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Заполните все значения формы!");
            }
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Admin.xaml", UriKind.Relative));
        }
    }
}
