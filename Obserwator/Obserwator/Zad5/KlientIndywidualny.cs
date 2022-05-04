using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class KlientIndywidualny : IObserwator
    {
     
        public void aktualizuj(double cena, SpolkaGieldowa spolka)
        {
           if((spolka.wycena *0.95)>=cena)
            {
                Console.WriteLine("Kupuje spółkę klient indywidualny "+spolka.nazwa);
            }
            else if((spolka.wycena * 1.1) <= cena)
            {
                Console.WriteLine("Sprzedaje spółkę klient indywidualny " + spolka.nazwa);
            }
            else
            {
                Console.WriteLine("Klient patrzy " + spolka.nazwa);
            }
        }
    }
}
