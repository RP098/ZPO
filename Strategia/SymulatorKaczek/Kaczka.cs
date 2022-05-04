using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
  
    public  class Kaczka
    {
        IKonkretnaKaczkaGadajaca gadanie;
        IKaczkaKonkretnaLatajaca latanie;
        public Kaczka(IKonkretnaKaczkaGadajaca gadanie, IKaczkaKonkretnaLatajaca latanie)
        {
            this.gadanie = gadanie;
            this.latanie = latanie;
        }
        public void Kwakanie()
        {
            gadanie.kwakanie();
        }

        public void Latanie()
        {
            latanie.fruwanie();
        }
    }
}
