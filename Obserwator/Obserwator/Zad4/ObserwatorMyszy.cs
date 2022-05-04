using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
  public  class ObserwatorMyszy : IObserwator
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public void aktualizuj(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine($"zmiana polozenia uwaga zmiana polozenia polozenie nowe x= {x} y= {y}");
        }
    }
}
