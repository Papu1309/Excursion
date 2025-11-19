using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
using System.IO;
using Магазин.Datagrid;
using Microsoft.Win32;
using Магазин.ListView;

namespace Магазин.Magas
{
    /// <summary>
    /// Логика взаимодействия для Vid.xaml
    /// </summary>
    public partial class aa : Page
    {
        public List<Spicok> Spicoks { get; set; }
        public ICollectionView PeopleView { get; set; }
        
        public aa()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            LoadSpicoks();
            SpicokListWiew.ItemsSource = Spicoks;
        }
        public void LoadSpicoks()
        {
            Spicoks = new List<Spicok>
            {
                  new Spicok() {Name = "Снегоходное сафари — охота за невероятными впечатлениями",Price = 155500,Foto = "/Photo/Снегоходное сафари — охота за невероятными впечатлениями.jpg",Data = "20-24 февраля",Tip = "Природный" },
                  new Spicok() {Name = "ЭКСПЕДИЦИОННЫЙ ТУР ДЛЯ ОПЫТНЫХ СНЕГОХОДЧИКОВ", Price = 299999 ,Foto = "/Photo/ЭКСПЕДИЦИОННЫЙ ТУР ДЛЯ ОПЫТНЫХ СНЕГОХОДЧИКОВ.jpg", Data = "17-22 февраля",Tip = "Исторический" },
                  new Spicok() {Name = "Новогоднее приключение", Price = 133630 ,Foto = "/Photo/Новогоднее приключение.jpeg", Data = "3-15 февраля",Tip = "Природный" },
                  new Spicok() {Name = "Самое популярное путешествие", Price = 136500 ,Foto = "/Photo/Самое популярное путешествие.jpg", Data = "1-3 февраля",Tip = "Природный" },
                  new Spicok() {Name = "Приключение, доступное каждому", Price = 80200,Foto = "/Photo/Приключение, доступное каждому.jpg", Data = "25-29 февраля",Tip = "Природный" },
                  new Spicok() {Name = "БЛИЦ-ПУТЕШЕСТВИЕ НА КАРАКОЛЬСКИЕ ОЗЕРА", Price = 199500 ,Foto = "/Photo/О маршруте.jpg", Data = "15-24 февраля",Tip = "Культурный" },
            };
            PeopleView = CollectionViewSource.GetDefaultView(Spicoks);
            

        }
        public void Korzina_Click(object sender, RoutedEventArgs e)
        {
            List<Spicok> selectedSpicoks = new List<Spicok>();

            foreach (var Spicok in Spicoks)
            {
                if (Spicok.IsSelected)
                {
                    selectedSpicoks.Add(Spicok);
                }
            }
            Corzina corzina = new Corzina(selectedSpicoks);
            corzina.Show();
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        private void SearchTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();

            var filteredProducts = Spicoks
                .Where(product => product.Tip.ToLower().Contains(searchText))
                .ToList();

            SpicokListWiew.ItemsSource = filteredProducts;
        }
    }
}
