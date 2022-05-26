using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Rodzajetransportu;
namespace Transport
{
    class ZwrocWybranaMetodeTransportuFabryka
    {
        public ITransport StworzPrzesylke(RodzajeTransportu rodzajeWysylki_Enum)
        {
            
            ITransport transport = null;
            switch (rodzajeWysylki_Enum) 
            {
               case  RodzajeTransportu.Pociag :
                    transport = new Pociag();
                    break;
                case RodzajeTransportu.Ciezarowka:
                    transport = new Ciezarowka();
                    break;
                case RodzajeTransportu.Morski:
                    transport = new Morski();
                    break;
                default :
                    transport = new  Ciezarowka() ;
                    break;
            }

            return transport;
        }
    }
}
