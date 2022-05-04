using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad5
{
    public class Gielda : IGieldaObserwator
    {
        static Random random = new Random( );
        List<SpolkaGieldowa> spolki = new List<SpolkaGieldowa>();
        public List<IObserwator> obserwatorsSpolki { get; set; } 
        public void dodajSpolke(string nazwa, double cena)
        {
            spolki.Add(new SpolkaGieldowa() { wycena = cena, dataNotowania = DateTime.Now, nazwa = nazwa });
        }

     

        public void powiadomienie(SpolkaGieldowa spolka, double nowaCena)
        {
          

            foreach (var item in obserwatorsSpolki)
            {
                item.aktualizuj(nowaCena, spolka);
            }


        }

        public void zmieniajCeneLosowychSpolek()
        {
            while (true)
            {
                Thread.Sleep(5000);
                int index = random.Next(0, spolki.Count - 1);
                double cenaNowa = random.NextDouble()+random.Next(0,1);
                spolki[index].wycena = spolki[index].wycena * cenaNowa;
                powiadomienie(spolki[index], spolki[index].wycena );

            }
        }

        public void usunSpolke(string nazwa)
        {
            var spolka = from c in spolki where c.nazwa == nazwa select c;
            spolki.Remove((SpolkaGieldowa)spolka);

        }
    }
}
