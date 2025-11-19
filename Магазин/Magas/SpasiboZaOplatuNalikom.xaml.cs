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

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для SpasiboZaOplatuNalikom.xaml
    /// </summary>
    public partial class SpasiboZaOplatuNalikom : Page
    {
        public SpasiboZaOplatuNalikom()
        {
            InitializeComponent();
        }

        private void btnCloses_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
