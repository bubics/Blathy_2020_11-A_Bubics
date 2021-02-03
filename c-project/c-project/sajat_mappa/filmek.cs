using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_project.sajat_mappa
{
    public class filmek
    {
        public filmek()
        {
            ertekeles = new List<ertekelesek>();
        }
        string film_nev;
        List<ertekelesek> ertekeles;

        public string Filmek { get => film_nev; set => film_nev = value; }
        public List<ertekelesek> Ertekeles { get => ertekeles; }
    }
}
