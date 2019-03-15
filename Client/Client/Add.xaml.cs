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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public int couID;
        public int sumID;
        public Add()
        {
            InitializeComponent();
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            comboBox_Copy.SelectedValuePath = "Value";
            comboBox_Copy.DisplayMemberPath = "Text";
            foreach (var element in Service.SelectCountry())
            {
                comboBox_Copy.Items.Add(new { Value = element.Country_ID, Text = element.Name });
            }

            comboBox.SelectedValuePath = "Value";
            comboBox.DisplayMemberPath = "Text";
            foreach (var element in Service.SelectSummit())
            {
                comboBox.Items.Add(new { Value = element.Summit_ID, Text = element.Name });
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
                ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
                if (comboBox.Text != "" && comboBox_Copy.Text != "" && StartD.Text!="" && FinishD.Text != "")
                {
                    ServiceReference1.Variant Service1 = new ServiceReference1.Variant();
                    Service1.StartDate = Convert.ToDateTime(StartD.SelectedDate);
                    Service1.FinishDate = Convert.ToDateTime(FinishD.SelectedDate);
                    Service1.country_id = Convert.ToInt32(couID);
                    Service1.summit_id = Convert.ToInt32(sumID);
                    Service1.user_id = Convert.ToInt32(Login.UserID);
                    Service.AddVariant(Service1.StartDate, Service1.FinishDate, Service1.country_id, Service1.user_id, Service1.summit_id);
                    NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("Заполните все значения формы!");
                }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Summit.xaml", UriKind.Relative));
        }

        private void button2_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Country.xaml", UriKind.Relative));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            for (int i = 0; i < Service.SelectSummit().Length; i++)
            {
                if (Convert.ToString(comboBox.SelectedItem) == Service.SelectSummit()[i].Name)
                {
                    sumID = Service.SelectSummit()[i].Summit_ID;
                }
            }
        }

        private void ComboBox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            for (int i = 0; i < Service.SelectCountry().Length; i++)
            {
                if (Convert.ToString(comboBox_Copy.SelectedItem) == Service.SelectCountry()[i].Name)
                {
                    couID = Service.SelectCountry()[i].Country_ID;
                }
            }

        }
    }
}
