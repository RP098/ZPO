using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    interface IObserwator
    {
        void update(int liczba,string tekst);
    }
}
