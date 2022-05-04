using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Zad4;
using Zad5;
using System.IO;
using System.Diagnostics;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {
            obserwator_3();
         
            obserwator_4();
            
            obserwator_5();
            Console.ReadKey();
        }

        private static void obserwator_5()
        {
            Bank bank = new Bank();
            MinisterFinasow minister = new MinisterFinasow();
            KlientIndywidualny klient = new KlientIndywidualny();
            Gielda gielda = new Gielda();
            gielda.obserwatorsSpolki = new List<Zad5.IObserwator>();
            gielda.obserwatorsSpolki.Add(bank);
            gielda.obserwatorsSpolki.Add(minister);
            gielda.obserwatorsSpolki.Add(klient);
            gielda.dodajSpolke("Facebook", 8000);
            gielda.dodajSpolke("Google", 10000);
            gielda.dodajSpolke("Slodycze", 200);

            Thread thread = new Thread(new ThreadStart(gielda.zmieniajCeneLosowychSpolek));
            thread.IsBackground = true;
            thread.Start();


        }

        private  static void obserwator_4()
        {
            ObserwatorMyszy adam = new ObserwatorMyszy();
            ObserwatorMyszy marek = new ObserwatorMyszy();
            ObserwatorMyszy czesio = new ObserwatorMyszy();
            MyszObserwowana mysz = new MyszObserwowana();
            mysz.dodajObserwatora(adam);
            mysz.dodajObserwatora(marek);
            mysz.dodajObserwatora(czesio);
            Thread thread = new Thread(new ThreadStart(mysz.obserwujMysz));
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Adam Marek Czesio obserwują mysz czekaj 8 sekund");
     
        }

        private static void obserwator_3()
        {
            ZmianaLiczba zmianaLiczba = new ZmianaLiczba();
            Liczby liczby = new Liczby();
            Console.WriteLine("Liczba 999 kończy");
            try
            {
                do
                {
                    liczby.liczba = int.Parse(Console.ReadLine());
                    zmianaLiczba.dodajLiczbe(liczby);

                } while (liczby.liczba != 999);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

       
    }
}

