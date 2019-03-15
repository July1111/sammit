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
using System.Data;


namespace Client
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
        public Menu()
        {
            InitializeComponent();
            
            comboBoxSummit.SelectedValuePath = "Value";
            comboBoxSummit.DisplayMemberPath = "Text";

            foreach (var element in Service.SelectSummit()) {
                comboBoxSummit.Items.Add(new {Value = element.Summit_ID, Text = element.Name });
            }
            
        }

        private void butMyVariant_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        private void ComboBoxCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGridVariants.ItemsSource = Service.SelectVariant((int)comboBoxSummit.SelectedValue);
            /*
            foreach (var element in Service.SelectVariant((int)comboBoxSummit.SelectedValue)) {
                dataGridVariants.Items.Add(element.StartDate);
            }*/


            /*if (comboBoxSummit.Text != "")
            {
                ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();

            }*/
        }

        private void ButOutput_Click(object sender, RoutedEventArgs e)
        {
            Login.UserID = 0;
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }
    }
}
