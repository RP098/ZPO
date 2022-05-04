using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Pracownik
    {
        public IPracowac pracowac { get; set; }
        public ISpedzanieWolnegoCzasu spedzanieWolnegoCzasu { get; set; }
        public IDojezdzac dojezdzac { get; set; }
        public Pracownik():this(new NaprawaSamochodow(),new LiteraturaPopularnoNaukowa(),new Rower()){}
        public Pracownik(IPracowac pracowac):this(pracowac,new LiteraturaPopularnoNaukowa(),new Rower()){}
        public Pracownik(IPracowac pracowac,ISpedzanieWolnegoCzasu spedzanieWolnegoCzasu) : this(pracowac, spedzanieWolnegoCzasu, new Rower()){}
        public Pracownik(IPracowac pracowac,ISpedzanieWolnegoCzasu spedzanieWolnegoCzasu,IDojezdzac dojezdzac)
        {
            this.pracowac = pracowac;
            this.spedzanieWolnegoCzasu = spedzanieWolnegoCzasu;
            this.dojezdzac = dojezdzac;
        }


    }
}
