using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
   public class KaczkaPlywajaca : Kaczka
    {
        public KaczkaPlywajaca(IKonkretnaKaczkaGadajaca gadanie, IKaczkaKonkretnaLatajaca latanie) : base(gadanie, latanie)
        {
        }
    }
}
