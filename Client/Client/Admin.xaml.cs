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
            int sum=0;
            int sum1=0;
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            for (int i = 0; i < Service.Summarizing().Length; i++)
            {

                if (i==0)
                {
                    sum = Service.Summarizing()[i].sum;
                }
                else if (i==1)
                {
                    sum1 = Service.Summarizing()[i].sum;
                    if (sum != sum1)
                    { MessageBox.Show("Победил вариант:\n" + Service.Summarizing()[i-1].country_name + "\n" + Service.Summarizing()[i-1].start_date.ToString("dd/MM/yyyy") + "\n" + Service.Summarizing()[i - 1].finish_date.ToString("dd/MM/yyyy") + "\nс результатом в " + sum + " голоса(ов)"); }
                    else { MessageBox.Show("Равное количество голосов, начните голосование заново, заранее удалив все голоса."); }
                }
            }
            




        }

        private void ButdeleteAllVoises_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();
            MessageBoxResult result = MessageBox.Show("Удалить все голоса?", "Голоса",
            MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Service.DeleteAllVoices();
                MessageBox.Show("Голоса успешно удалены");
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
