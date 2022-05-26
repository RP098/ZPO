using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Rodzajetransportu
{
    class Morski : ITransport
    {
        public void Transportuj()
        {
            Console.WriteLine($"Transportuje drogą morska");
        }



    }
}
