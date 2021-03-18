using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace film_ertekeles
{
    class MainVM : ViewModelBase
    {
        public MainVM()
        {
            this.PropertyChanged += MainVM_PropertyChanged;
            Elemek = new ObservableCollection<string>();
            Add = new RelayCommand(Add_action);
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

        public ICommand Add { get; set; }
        private void Add_action()
        {
            if (!string.IsNullOrWhiteSpace(SearchWord))
            {
                Elemek.Add(SearchWord);
                SearchWord = "";
            }
        }
        public ObservableCollection<string> Elemek { get; private set; }
    }
}
