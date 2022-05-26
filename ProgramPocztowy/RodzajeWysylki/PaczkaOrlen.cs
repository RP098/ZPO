using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPocztowy.RodzajeWysylki
{
    class PaczkaOrlen:IWysylka
    {
        public void Wyslij(Product product)
        {
            Console.WriteLine($"Paczka z {product.nazwa} czeka na orlenie do zaplaty {product.cena + 15} ");
        }

      

    }
}
