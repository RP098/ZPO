using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    interface IObserwujPolozenieMyszki <T>
    {
        void dodajObserwatora( T obserwator);
        void usunObserwatora( T obserwator );
        void powiadomOzmianie( int y, int x );
    }
}
