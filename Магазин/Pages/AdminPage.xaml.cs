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
using Магазин.Magas;

namespace Магазин.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnVxodd_Click(object sender, RoutedEventArgs e)
        {
            if(loginTb.Text == "Admin" && ParolTb.Text == "1309")
            {
                //NavigationService.Navigate(new VidAdmin());
                MessageBox.Show("Ну это на 4 :)", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void txbBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
