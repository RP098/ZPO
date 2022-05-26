using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Rodzajetransportu;
namespace Transport
{
    public class DokonajWyboruTransportu
    {
        ITransport transport = null;

        public void WybierzRodzajTransportu(RodzajeTransportu rodzajeTransportu)
        {
            ZwrocWybranaMetodeTransportuFabryka zwrocWybranaPrzesylkeFabryka = new ZwrocWybranaMetodeTransportuFabryka();
            this.transport= zwrocWybranaPrzesylkeFabryka.StworzPrzesylke(rodzajeTransportu);
            transport.Transportuj();
        }
    }
}
