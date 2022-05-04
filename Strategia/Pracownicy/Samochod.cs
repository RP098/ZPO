using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Samochod : IDojezdzac
    {
        public void dojezdzac()
        {
            Console.WriteLine("Dojezdzam samochodem");
        }
    }
}
