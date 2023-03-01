using Informationsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;
using System.Text;
using System.IO;

namespace Informationsystem
{
   //class Sauce
   //{}
   // class Wasabi
   // {
   //     public int levelofsharpness { get; set; }
   // }
   // class Imbir
   // {
   //     public string color { get; set; }
   // }
   public class Item: INotifyPropertyChanged
   {
        private string name;
        private int price;
        private int sauce;
        private int wasabi;
        private int imbir;
        public int totalAmount;
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

        private RelayCommand orderCommand;

        public ICommand OrderCommand
        {
            get
            {
                return orderCommand ?? (orderCommand = new RelayCommand(obj =>
                {
                    int price = this.price + this.sauce * 50 + this.wasabi * 30 + this.imbir * 20;
                    MessageBox.Show("Итого к оплате: " + price.ToString());

                    StreamWriter sw = new StreamWriter("D:\\2 курс\\программировние ч2\\Informationsystem\\Informationsystem\\orderlist.txt", true, Encoding.ASCII);
                    sw.WriteLine("New order");
                    sw.WriteLine("-------------------");
                    sw.WriteLine("Set: " + this.Name);
                    sw.WriteLine("Amount of sauce, imbir, wasabi: ");
                    sw.WriteLine(this.Sauce + " " + this.Imbir + " " + this.Wasabi);
                    sw.WriteLine("Price: " + price);
                    sw.WriteLine("-------------------");
                    sw.WriteLine("");
                    sw.Close();
                }
                ));
            }
        }

        private void Order(object commandParameter)
        {
        }
    }
}
