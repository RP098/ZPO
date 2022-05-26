using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramPocztowy.RodzajeWysylki;
namespace ProgramPocztowy
{
    public class DokonajWyboruWysylki
    {
        IWysylka wysylka = null;

        public void WybierzRodzajWysylki(RodzajeWysylki_enum rodzajeWysylki, Product product)
        {
            ZwrocWybranaPrzesylkeFabryka zwrocWybranaPrzesylkeFabryka = new ZwrocWybranaPrzesylkeFabryka();
            this.wysylka = zwrocWybranaPrzesylkeFabryka.StworzPrzesylke(rodzajeWysylki);
            wysylka.Wyslij(product);
        }
    }
}
