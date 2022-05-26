using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPocztowy.RodzajeWysylki
{
    class PaczkomatyImpost : IWysylka
    {
        public void Wyslij(Product product)
        {
            Console.WriteLine($"Paczka z {product.nazwa} czeka w paczkomacie do zaplaty {product.cena + 10} ");
        }



    }
}
