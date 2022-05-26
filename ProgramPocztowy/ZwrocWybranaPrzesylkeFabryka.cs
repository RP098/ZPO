using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramPocztowy.RodzajeWysylki;
namespace ProgramPocztowy
{
    class ZwrocWybranaPrzesylkeFabryka
    {
        public IWysylka StworzPrzesylke(RodzajeWysylki_enum rodzajeWysylki_Enum)
        {
            
            IWysylka wysylka = null;
            switch (rodzajeWysylki_Enum) 
            {
               case  RodzajeWysylki_enum.PaczkaOrlen :
                    wysylka = new PaczkaOrlen();
                    break;
                case RodzajeWysylki_enum.ZaPobraniem:
                    wysylka = new ZaPobraniem();
                    break;
                case RodzajeWysylki_enum.PaczkomatyImpost:
                    wysylka = new PaczkomatyImpost();
                    break;
                default : wysylka = new  ZaPobraniem() ;
                    break;
            }


         

            return wysylka;
        }
    }
}
