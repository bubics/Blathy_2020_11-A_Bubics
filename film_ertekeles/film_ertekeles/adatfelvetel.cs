using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_ertekeles
{
    class adatfelvetel : ObservableObject
    {
        /*
        public adatfelvetel()
        {
            this.PropertyChanged += adatfelvetel_PropertyChanged;
        }

        private void adatfelvetel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }
        */

        private string film_name;
        private int film_ertekeles;

        public string Film_name { get => film_name; set => Set(ref film_name, value); }
        public int Film_ertekeles { get => film_ertekeles; set => Set(ref film_ertekeles, value); }

        public override string ToString()
        {
            return $"{film_name}";
        }
    }
}
