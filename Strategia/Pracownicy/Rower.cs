using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
   public class Rower : IDojezdzac
    {
        public void dojezdzac()
        {
            Console.WriteLine("Dojezdzam rowerem");
        }
    }
}
