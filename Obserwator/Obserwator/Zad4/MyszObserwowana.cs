using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad4
{
    

   public class MyszObserwowana : IObserwujPolozenieMyszki<IObserwator>
    {
        static Random random = new Random();
        List<IObserwator> obserwators = new List<IObserwator>();
        public int X { get; }
        public void dodajObserwatora(IObserwator obserwator)
        {
            obserwators.Add(obserwator);
        }

      
        public void powiadomOzmianie(int y, int x)
        {
            foreach (var item in obserwators)
            {
                item.aktualizuj(x, y);
            }
        }


        public  void obserwujMysz()
        {
           
                while (true)
                {
                    Thread.Sleep(8000);
                    powiadomOzmianie(random.Next(0, 100), random.Next(0, 100));
                }
          
          

        }

        public void usunObserwatora(IObserwator obserwator)
        {
            obserwators.Remove(obserwator);
        }
    }
}
