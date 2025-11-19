using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Data;
using Магазин.Datagrid;

namespace Магазин.ListView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Spicok> Spicoks { get; set; }
        public ICollectionView PeopleView { get; set; }
        public string _filterText;
        public string FilterText
        {
            get => _filterText;
            set
            {
                _filterText = value;
                OnPropertyChanged(nameof(FilterText));
                PeopleView.Refresh(); // Обновляем представление при изменении фильтра
            }
        }


        public MainViewModel()
        {
            Spicoks = new List<Spicok>
            {
                new Spicok() { Name = "Снегоходное сафари — охота за невероятными впечатлениями", Price = 155500, Foto = "/Photo/Снегоходное сафари — охота за невероятными впечатлениями.jpg", Data = "20-24 февраля",Tip = "Природный" },
                  new Spicok() { Name = "ЭКСПЕДИЦИОННЫЙ ТУР ДЛЯ ОПЫТНЫХ СНЕГОХОДЧИКОВ", Price = 299999, Foto = "/Photo/ЭКСПЕДИЦИОННЫЙ ТУР ДЛЯ ОПЫТНЫХ СНЕГОХОДЧИКОВ.jpg", Data = "17-22 февраля",Tip = "Исторический" },
                  new Spicok() { Name = "Новогоднее приключение", Price = 133630, Foto = "/Photo/Новогоднее приключение.jpeg", Data = "3-15 февраля",Tip = "Природный" },
                  new Spicok() { Name = "Самое популярное путешествие", Price = 136500, Foto = "/Photo/Самое популярное путешествие.jpg", Data = "1-3 февраля",Tip = "Природный" },
                  new Spicok() { Name = "Приключение, доступное каждому", Price = 80200, Foto = "/Photo/Приключение, доступное каждому.jpg", Data = "25-29 февраля",Tip = "Природный" },
                  new Spicok() { Name = "БЛИЦ-ПУТЕШЕСТВИЕ НА КАРАКОЛЬСКИЕ ОЗЕРА", Price = 199500, Foto = "/Photo/О маршруте.jpg", Data = "15-24 февраля",Tip = "Культурный" },
           };
            PeopleView = CollectionViewSource.GetDefaultView(Spicoks);
            PeopleView.Filter = FilterPeople; // Устанавливаем фильтр
        }
        public bool FilterPeople(object obj)
        {
            if (obj is Spicok spicok)
            {
                return string.IsNullOrEmpty(FilterText) || spicok.Name.Contains(FilterText);
            }
            return false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

    }
}
