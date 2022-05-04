using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class Liczby : IObserwator
    {

        public int liczba=0;
        public int wybor=9;
        public void update(int liczba,string powiadomienie)
        {
            
            Console.WriteLine("Dodano liczbę "+powiadomienie+" wartosc = "+ liczba);
            Console.WriteLine("Wybierz jakie liczby mam przechwytywać");
            Console.WriteLine("1. Liczba większa od zera");
            Console.WriteLine("2. Liczna równa trzy");
            Console.WriteLine("3. Liczba podzielna przez 2");
            wybor = int.Parse(Console.ReadLine());
            switch (wybor) 
            {  
                case 1:
                    liczbaWieksza_Zero();
                    break;
                case 2:
                    liczbaRowna_trzy();
                    break;
                case 3:
                    liczbapodzielna_przez_dwa();
                    break;
            
        }


        }

        private void liczbapodzielna_przez_dwa()
        {
            Console.WriteLine("Podaj liczbe 999 kończy");
            do
            {
                liczba= int.Parse(Console.ReadLine());
                if(liczba%2==0)
                    Console.WriteLine("liczba podzielna przez dwa");

            } while (liczba!=999);
            Console.Clear();
            Console.WriteLine("Podaj liczbe 999 kończy");
            return;
        }

        private void liczbaRowna_trzy()
        {
            Console.WriteLine("Podaj liczbe 999 kończy");
            do
            {
                liczba = int.Parse(Console.ReadLine());
                if (liczba == 3)
                    Console.WriteLine("liczba podzielna równa trzy");

            } while (liczba != 999);
            Console.Clear();
            Console.WriteLine("Podaj liczbe 999 kończy");
            return;
        }

        private void liczbaWieksza_Zero()
        {
            Console.WriteLine("Podaj liczbe 999 kończy");
            do
            {
                liczba = int.Parse(Console.ReadLine());
                if (liczba > 0)
                    Console.WriteLine("liczba większa od zera");

            } while (liczba != 999);
            Console.Clear();
            Console.WriteLine("Podaj liczbe 999 kończy");
            return;
        }

    }
}
