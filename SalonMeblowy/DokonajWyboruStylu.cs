using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonMeblowy.RodzajStylow;
using SalonMeblowy.Produkty;
namespace SalonMeblowy
{
    public class DokonajWyboruStylu
    {
        IStyl styl = null;

        public void WybierzRodzajStylu(RodzajeStylow_enum rodzajeWysylki, Mebel product)
        {
            ZwrocWybranaStylFabryka zwrocWybranaPrzesylkeFabryka = new ZwrocWybranaStylFabryka();
            this.styl = zwrocWybranaPrzesylkeFabryka.StworzPrzesylke(rodzajeWysylki);
            styl.StylizacjaProduktu(product);
        }
    }
}
