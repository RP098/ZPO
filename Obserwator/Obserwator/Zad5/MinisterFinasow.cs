using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class MinisterFinasow : IObserwator
    {
        List<SpolkaGieldowa> spolkas = new List<SpolkaGieldowa>();
        public void aktualizuj(double cena, SpolkaGieldowa spolka)
        {

            var d = (from s in spolkas where s.nazwa == spolka.nazwa select s).ToList().Count;
            if ( d ==0 )
            {
                Console.WriteLine($"Uwaga raz dwa trzy Pan Minister patrzy {spolka.nazwa} {cena}");
                Console.WriteLine();
                spolkas.Add(new SpolkaGieldowa() { dataNotowania=spolka.dataNotowania,wycena=spolka.wycena,nazwa=spolka.nazwa} );
            }
            else
            {
                SpolkaGieldowa spolka1 = new SpolkaGieldowa();
                foreach ( var item in spolkas)
                {
                    if (item.nazwa == spolka.nazwa)
                    {
                        item.wycena = (cena + item.wycena)/2;
                        spolka1 = item;
                        break;
                    }
                }
                Console.WriteLine("Minister finasów patrzy  " + spolka.nazwa +" średnia cena spółki to " + spolka1.wycena +" rzeczywista cena " + spolka.wycena );
                Console.WriteLine();
            }
        }
    }
}
