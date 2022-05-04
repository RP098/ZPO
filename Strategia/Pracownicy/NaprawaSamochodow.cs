using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class NaprawaSamochodow : IPracowac
    {
        public void pracuj()
        {
            Console.WriteLine("Naprawiam Samochody");
        }
    }
}
