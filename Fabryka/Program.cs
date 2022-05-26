using System;
using ProgramPocztowy;
using Transport;
using SalonMeblowy;
using SalonMeblowy.Produkty;
namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program pierwszy \n");

            Product product = new Product();
            DokonajWyboruWysylki dokonajWyboru = new DokonajWyboruWysylki();
            dokonajWyboru.WybierzRodzajWysylki(RodzajeWysylki_enum.PaczkomatyImpost, product);
            Console.WriteLine("Program drugi \n");

            DokonajWyboruTransportu dokonajWyboruTransportu = new DokonajWyboruTransportu();
            dokonajWyboruTransportu.WybierzRodzajTransportu(RodzajeTransportu.Morski);
           
            Console.WriteLine("Program trzeci \n");

            Mebel mebelSofa = new Sofa();
            Mebel mebelStolik = new StolikKawowy();
            Mebel mebelFotel = new Fotel();
            DokonajWyboruStylu dokonajWyboruStylu = new DokonajWyboruStylu();
            RodzajeStylow_enum rodzajeStylDnia = RodzajeStylow_enum.Nowoczesny;
            dokonajWyboruStylu.WybierzRodzajStylu(rodzajeStylDnia, mebelSofa);
            dokonajWyboruStylu.WybierzRodzajStylu(rodzajeStylDnia, mebelStolik);
            dokonajWyboruStylu.WybierzRodzajStylu(rodzajeStylDnia, mebelFotel);
            Console.ReadKey();
        }
    }
}
