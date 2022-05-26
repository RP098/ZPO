using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonMeblowy.Produkty
{
    public abstract class Mebel
    {
        public string nazwa;
        public override string ToString()
        {
            return this.GetType().Name; 
        }
    }
}
