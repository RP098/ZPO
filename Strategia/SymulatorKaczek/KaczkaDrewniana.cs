﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorKaczek
{
    public class KaczkaDrewniana : Kaczka
    {
        public KaczkaDrewniana(IKonkretnaKaczkaGadajaca gadanie, IKaczkaKonkretnaLatajaca latanie) : base(gadanie, latanie)
        {
        }
    }
}
