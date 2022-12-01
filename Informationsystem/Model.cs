using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Informationsystem
{
   public class Item: INotifyPropertyChanged
    {
        private string name;
        private int price;
        private int sauce;
        private int wasabi;
        private int imbir;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public int Sauce
        {
            get { return sauce; }
            set
            {
                sauce = value;
                OnPropertyChanged("Sauce");
            }
        }
        public int Wasabi
        {
            get { return wasabi; }
            set
            {
                wasabi = value;
                OnPropertyChanged("Wasabi");
            }
        }
        public int Imbir
        {
            get { return imbir; }
            set
            {
                imbir = value;
                OnPropertyChanged("Imbir");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
