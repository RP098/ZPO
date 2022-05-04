using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public interface IObserwator
    {
        void aktualizuj( double cena , SpolkaGieldowa spolka);
    }
}
