using SalonMeblowy.Produkty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonMeblowy.RodzajStylow
{
    class Wiktorianski : IStyl
    {
        public void StylizacjaProduktu(Mebel mebel)
        {
            Console.WriteLine($"Styl twojego produktu {mebel.ToString()} to Wiktorianski");
        }
    }
}
