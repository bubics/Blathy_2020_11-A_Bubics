using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film_ertekeles.Model
{
    public class filmek : ObservableObject
    {
        [Key]
        public string Filma { get => filma; set => Set(ref filma, value); }
        [Required]
        public int Ertekelesa { get => ertekelesa; set => Set(ref ertekelesa, value); }

        private string filma;
        private int ertekelesa;
    }
}
