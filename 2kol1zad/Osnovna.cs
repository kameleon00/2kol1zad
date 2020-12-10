using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol1zad
{
    class Osnovna : IGlavni
    {
        public string opis;
        //metoda interfejsa iglavni
        public void glavni()
        {
            opis = "GLAVNI";
            Console.WriteLine(opis);
        }

        public virtual void prvi()
        {
            opis = "PRVI";
            Console.WriteLine(opis);
        }
        public virtual void drugi()
        {
            opis = "DRUGI";
            Console.WriteLine(opis);
        }

    }
}
