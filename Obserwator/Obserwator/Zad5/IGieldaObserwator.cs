using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public interface IGieldaObserwator
    {
        void dodajSpolke(string nazwa, double cena);
        void usunSpolke(string nazwa);
        void powiadomienie(SpolkaGieldowa spolka, double nowaCena);

    }
}
