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
            //Osoba a = new Osoba();
            //a.Imie = "Beata";
            //a.nazwisko = "Nowak";
            //DateTime aDataUrodzenia = new DateTime(1992, 10, 22);
            //a.Pesel = "92102201347";
            //a.Plec1 = Plcie.K;
            //Console.WriteLine(a.Imie + " " + a.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", aDataUrodzenia) + " " + a.Pesel + " " + a.Plec1);

            //Osoba b = new Osoba();
            //b.Imie = "Jan";
            //b.nazwisko = "Janowski";
            //DateTime bDataUrodzenia = new DateTime(1992, 3, 15);
            //b.Pesel = "92031507772";
            //b.Plec1 = Plcie.M;
            //Console.WriteLine(b.Imie + " " + b.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", bDataUrodzenia) + " " + b.Pesel + " " + b.Plec1);

            //CzlonekZespolu c = new CzlonekZespolu();
            //c.Imie = "Beata";
            //c.nazwisko = "Nowak";
            //DateTime cDataUrodzenia = new DateTime(1992, 10, 22);
            //c.Pesel = "92102201347";
            //c.Plec1 = Plcie.K;
            //c.funkcja = "projektant";
            //Console.WriteLine(c.Imie + " " + c.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", cDataUrodzenia) + " " + c.Pesel + " " + c.Plec1 + " " + c.funkcja);

            //CzlonekZespolu d = new CzlonekZespolu();
            //d.Imie = "Jan";
            //d.nazwisko = "Janowski";
            //DateTime dDataUrodzenia = new DateTime(1992, 3, 15);
            //d.Pesel = "92031507772";
            //d.Plec1 = Plcie.M;
            //d.funkcja = "programista";
            //Console.WriteLine(d.Imie + " " + d.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", dDataUrodzenia) + " " + d.Pesel + " " + d.Plec1 + " " + d.funkcja);

            //KierownikZespolu e = new KierownikZespolu();
            //e.Imie = "Adam";
            //e.nazwisko = "Kowalski";
            //DateTime eDataUrodzenia = new DateTime(1990, 7, 1);
            //e.Pesel = "90070100211";
            //e.Plec1 = Plcie.M;
            //e.doswiadczenie = 5;
            //Console.WriteLine(e.Imie + " " + e.nazwisko + " " + String.Format("{0:yyyy-MM-dd }", eDataUrodzenia) + " " + e.Pesel + " " + e.Plec1 + " " + e.doswiadczenie);

            CzlonekZespolu f = new CzlonekZespolu();
            f.Imie = "Adam";
            f.nazwisko = "Kowalski";
            f.Plec1 = Plcie.M;
            DateTime fDataUrodzenia = new DateTime(1990, 7, 1);
            f.Pesel = "90070100211";
            f.funkcja = "programista";

            f.SprawdzPesel(f.Pesel);
            Console.WriteLine(f.ToString());
            Console.ReadKey();
        }
    }
}
    

