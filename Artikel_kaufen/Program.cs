using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikel_kaufen
{

    class Program
    {
        double einzelpreis, menge, rabatt, gesamtpreis;
        Boolean neuerArtikel = true;
        static void Main(string[] args)
        {
            Program aufgabeA = new Program();
            Program aufgabeB = new Program();

            aufgabeA.Ausgabe();
        }

        public void Ausgabe()
        {
            artikel();
            rabattF();
            Console.WriteLine("Rabatt:              " + rabatt);
            Console.Write("Gesamtpreis:         " + gesamtpreis);
            Console.ReadKey();
        }

        public void rabattF()
        {
            double oldGesamt = gesamtpreis;

            if (gesamtpreis >= 100 && gesamtpreis < 500)
            {
                gesamtpreis = gesamtpreis * 0.95;
            }
            else if (gesamtpreis >= 500)
            {
                gesamtpreis = gesamtpreis * 0.93;
            }
            rabatt = oldGesamt - gesamtpreis;
        }

        public void artikel()
        {
            while (neuerArtikel == true)
            {
                Console.Write("Einzelpreis:         ");
                einzelpreis = Convert.ToDouble(Console.ReadLine());
                Console.Write("Menge:               ");
                menge = Convert.ToDouble(Console.ReadLine());
                gesamtpreis = gesamtpreis + (menge * einzelpreis);

                Console.Write("weiter Artikel?  ");

                if (Console.ReadLine() == "j")
                {
                    neuerArtikel = true;
                }
                else
                    neuerArtikel = false;
            }
        }
    }
}
