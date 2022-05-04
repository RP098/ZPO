using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class ZmianaLiczba : ILiczba
    {
        List<Liczby> liczby = new List<Liczby>();
        public void dodajLiczbe(Liczby liczba)
        {
            liczby.Add(liczba);
            if (liczba.liczba == 0)
                powiadomienie(liczba.liczba, "równa zero");
            else
                usunLiczbe(liczba);
        }

        public void powiadomienie(int liczba, string tekst)
        {
            foreach (var item in liczby)
            {
                item.update(liczba, tekst);
            }
        }


        public void usunLiczbe(Liczby liczba)
        {
            liczby.Remove(liczba);

        }

       
    }
}
