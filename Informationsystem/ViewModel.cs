using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.IO;
using System.Windows;

namespace Informationsystem
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Item selectedItem;

        public ObservableCollection<Item> Items { get; set; }

        const string MINI = "/pictures/mini.png";
        const string MEDIUM = "/pictures/medium.png";
        const string MAX = "/pictures/max.png";

        

        readonly MainWindow _this;

        public Item SelectedItem
        {
          get {return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
  
        }

        public ViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item{Name="Mini",Price=500,Sauce=1,Wasabi=1,Imbir=1 },
                new Item{Name="Medium",Price=1000,Sauce=2,Wasabi=2,Imbir=2  },
                new Item{Name="Max",Price=1500,Sauce=3,Wasabi=3,Imbir=3  }
            };

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ViewModel(MainWindow mainWindow)
        {
            _this = mainWindow;
        }


    }
}
