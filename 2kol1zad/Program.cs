using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kol1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Osnovna o = new Osnovna(); //istanca
            o.opis = "OSNOVNA";//podesavanje vrednosti polja
            Console.WriteLine(o.opis);
            o.glavni();//-----------------------------------------------------------------
            o.prvi();//-----pozivamo sve metode interfejsa preko istance klase osnovna----
            o.drugi();//------------------------------------------------------------------
            Console.WriteLine();

            IGlavni ig = new Osnovna();
            ig.glavni();//-----------------------------------------------------------------
            ig.prvi();//-----pozivamo sve metode interfejsa preko istance interfejsa-------
            ig.drugi();//------------------------------------------------------------------
            Console.WriteLine();


            Izvedena iz = new Izvedena();
            iz.opis = "IZVEDENA";
            iz.b = 5;
            Console.WriteLine(iz.opis+"  "+iz.b);
            iz.glavni();//------------------------------------------------------------------
            iz.prvi();//-----pozivamo sve metode interfejsa preko istance klase izvedena----
            iz.drugi();//-------------------------------------------------------------------
            Console.WriteLine();


            IGlavni igi = new Izvedena();
            igi.glavni();//------------------------------------------------------------------
            igi.prvi();//-----pozivamo sve metode interfejsa preko istance interfejsa--------
            igi.drugi();//-------------------------------------------------------------------
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
