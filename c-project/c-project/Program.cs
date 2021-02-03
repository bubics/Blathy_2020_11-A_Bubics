using c_project.sajat_mappa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_project
{
    class Program
    {
        static void Main(string[] args)
        {
            filmek i = new filmek();
            i.Filmek = "Bosszúállók";
            ertekelesek j = new ertekelesek();
            j.Ertekeles = 9.5;
            Console.WriteLine(i.Filmek + j.Ertekeles);
        }
    }
}
