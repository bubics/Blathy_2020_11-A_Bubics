using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_ertekeles
{
    class MainVM : ViewModelBase
    {
        public MainVM()
        {
            this.PropertyChanged += MainVM_PropertyChanged;
        }

        private void MainVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SearchWord":
                    Db = SearchWord.Length;
                    break;
                default:
                    break;
            }
        }

        private string searchWord;
        private int db;

        public string SearchWord { get => searchWord; set => Set(ref searchWord, value); }
        public int Db { get => db; set => Set(ref db, value); }
    }
}
