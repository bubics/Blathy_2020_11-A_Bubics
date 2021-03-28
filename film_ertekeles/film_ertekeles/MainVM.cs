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
            ADD = new RelayCommand(Add2, AddCanExecute);
            NEW = new RelayCommand(New, NewCanExecute);
            DEL = new RelayCommand(Del, DelCanExecute);
            Adatfelvetel = new ObservableCollection<adatfelvetel>();
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
                case "Selected":
                    SelectedNotNull = Selected != null;
                    break;
                default:
                    break;
            }
        }

        private string searchWord;
        private int db;
        private adatfelvetel selected;
        private bool selectedNotNull;

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
        public ObservableCollection<adatfelvetel> Adatfelvetel { get; private set; }
        public adatfelvetel Selected { get => selected; set => Set(ref selected, value); }
        public bool SelectedNotNull { get => selectedNotNull; set => Set(ref selectedNotNull, value); }

        public ICommand ADD { get; private set; }
        public ICommand NEW { get; private set; }
        public ICommand DEL { get; private set; }
        
        private void Add2()
        {
            Adatfelvetel.Add(Selected);
        }
        private bool AddCanExecute()
        {
            return SelectedNotNull && !string.IsNullOrWhiteSpace(Selected.Film_name) && !Adatfelvetel.Contains(Selected);
        }
        private void New()
        {
            Selected = new adatfelvetel();
        }
        private bool NewCanExecute()
        {
            return true;
        }
        private void Del()
        {
            Adatfelvetel.Remove(Selected);
        }
        private bool DelCanExecute()
        {
            return SelectedNotNull && Adatfelvetel.Contains(Selected);
        }
    }
}
