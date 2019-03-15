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
            label_error.Content = "";
            dataGridVariants.Items.Clear();
            dataGridVariants.Items.Refresh();
            butAddVoice.IsEnabled = true;

            if (Service.SelectVariant((int)comboBoxSummit.SelectedValue) != null)
            {
                dataGridVariants.SelectedValuePath = "id";
                foreach (var element in Service.SelectVariant((int)comboBoxSummit.SelectedValue))
                {
                    dataGridVariants.Items.Add(new {id = element.variant_id, startdate = element.StartDate.ToString("dd/MM/yyyy"), enddate = element.FinishDate.ToString("dd/MM/yyyy"), country = element.country, user = element.user });
                }
            }
            else {
                label_error.Content = "Вариантов нет";
            }
            dataGridVariants.Columns[0].Visibility = Visibility.Hidden;

            if (Service.CheckVoice(Properties.Settings.Default.User_ID, (int)comboBoxSummit.SelectedValue) == true) {
                butAddVoice.IsEnabled = false;
               
            }

        }

        private void ButAddVoice_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridVariants.SelectedValue != null)
            {
                var addVoice = Service.AddVoice(Properties.Settings.Default.User_ID, (int)dataGridVariants.SelectedValue);
                if (addVoice.error == false)
                {
                    MessageBox.Show("Вы успешно проголосовали!");
                }
                else
                {
                    MessageBox.Show("За свой вариант нельзя голосовать!");
                }
                if (Service.CheckVoice(Properties.Settings.Default.User_ID, (int)comboBoxSummit.SelectedValue) == true)
                {
                    butAddVoice.IsEnabled = false;
                }
            }
            else {

                MessageBox.Show("Выберете вариант!");
            }
            
        }

        private void ButOutput_Click(object sender, RoutedEventArgs e)
        {
            Login.UserID = 0;
            NavigationService.Navigate(new Uri("/Login.xaml", UriKind.Relative));
        }
    }
}
