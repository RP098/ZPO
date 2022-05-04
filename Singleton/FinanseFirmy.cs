using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    
    public class FinanseFirmy
    {
        public static Dictionary<string,FinanseFirmy> mapa = new Dictionary<string, FinanseFirmy>();
       
        public string NazwaMiesiaca { get; set; }
        public double Przychody { get; set; }


        private FinanseFirmy()
        {

        }
        private FinanseFirmy(string key)
        {
            PobierzDane pobierz = new PobierzDane();
            this.NazwaMiesiaca = pobierz.ReadFile(key).Trim().Split(new char [] { ':'})[0];
            this.Przychody = Convert.ToDouble(pobierz.ReadFile(key).Trim().Split(new char[] { ':' })[1]);
        }

        public static FinanseFirmy PobierzInstancje(string key)
        {
            if(!FinanseFirmy.mapa.ContainsKey(key))
            {
                FinanseFirmy.mapa.Add(key, new FinanseFirmy(key));
                return FinanseFirmy.mapa[key];
            }
            else
            {
                return FinanseFirmy.mapa[key];
            }
        }
    }
}
