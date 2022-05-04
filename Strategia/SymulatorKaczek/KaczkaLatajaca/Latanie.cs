using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
    public class Latanie : IKaczkaKonkretnaLatajaca
    {
        public void fruwanie()
        {
            Console.WriteLine("Fru fru fru");
        }
    }
}
