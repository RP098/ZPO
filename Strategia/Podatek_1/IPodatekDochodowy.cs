using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatek_1
{
    public interface IPodatekDochodowy
    {
        decimal podatekDochodowyOblicz(decimal Kwota);
    }
}
