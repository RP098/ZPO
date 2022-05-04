using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
  public  class Bank : IObserwator
    {

        public void aktualizuj(double cena,SpolkaGieldowa spolka)
        {
            if (cena > 10000 )
            {
                Console.WriteLine("Bank kupuje społkę"+ spolka.nazwa);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Bank obserwuje nadal" +spolka.nazwa);
                Console.WriteLine();
            }
      
           
        }
    }
}
