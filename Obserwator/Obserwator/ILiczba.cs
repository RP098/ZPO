using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    interface ILiczba
    {
        void dodajLiczbe(Liczby liczba);
        void usunLiczbe(Liczby liczba);
        void powiadomienie(int liczba, string tekst);
        
    }
}
