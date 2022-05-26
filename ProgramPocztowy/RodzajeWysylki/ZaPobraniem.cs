using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPocztowy.RodzajeWysylki
{
     class ZaPobraniem : IWysylka
    {
        public void Wyslij(Product product)
        {
            Console.WriteLine($"Paczka z {product.nazwa} za pobraniem do zaplaty {product.cena + 25} ");
        }



    }
}
