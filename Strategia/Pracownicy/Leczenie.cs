﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Leczenie : IPracowac
    {
        public void pracuj()
        {
            Console.WriteLine("Pracuję lecząc ludzi");
        }
    }
}
