using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonMeblowy.RodzajStylow;
namespace SalonMeblowy
{
    class ZwrocWybranaStylFabryka
    {
        public IStyl StworzPrzesylke(RodzajeStylow_enum rodzajeStylow_Enum)
        {
            
            IStyl styl = null;
            switch (rodzajeStylow_Enum) 
            {
               case  RodzajeStylow_enum.ArtDeco :
                    styl = new ArtDeco();
                    break;
                case RodzajeStylow_enum.Nowoczesny:
                    styl = new Nowoczesny();
                    break;
                case RodzajeStylow_enum.Wiktorianski:
                    styl = new Wiktorianski();
                    break;
                default : styl = new  Wiktorianski() ;
                    break;
            }


         

            return styl;
        }
    }
}
