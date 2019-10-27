using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    class Program

    {
        public enum Plcie { K, M }
        static void Main(string[] args)
        {
            Osoba a = new Osoba();
            a.Imie = "Beata";
            a.nazwisko = "Nowak";
            DateTime aDataUrodzenia = new DateTime(1992, 10, 22);
            a.Pesel = "92102201347";
            a.Plec1 = Plcie.K;    
            Console.WriteLine(a.Imie + " " + a.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", aDataUrodzenia) + " " + a.Pesel + " " + a.Plec1);
           
            Osoba b = new Osoba();
            b.Imie = "Jan";
            b.nazwisko = "Janowski";
            DateTime bDataUrodzenia = new DateTime(1993, 3, 15);
            b.Pesel = "92031507772";
            b.Plec1 = Plcie.M;
            Console.WriteLine(b.Imie + " " + b.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", bDataUrodzenia) + " " + b.Pesel + " " + b.Plec1);
            Console.ReadKey();
        }
    }
}
    

