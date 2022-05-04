using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            FinanseFirmy finanse=null;
            finanse = FinanseFirmy.PobierzInstancje("Styczeń");
            finanse = FinanseFirmy.PobierzInstancje("Luty");
            finanse = FinanseFirmy.PobierzInstancje("Marzec");
            finanse = FinanseFirmy.PobierzInstancje("Kwiecień");
            finanse = FinanseFirmy.PobierzInstancje("Maj");
            finanse = FinanseFirmy.PobierzInstancje("Czerwiec");
            finanse = FinanseFirmy.PobierzInstancje("Lipiec");
            FinanseFirmy finanse1 = null;
            finanse1 = FinanseFirmy.PobierzInstancje( "Lipiec");
            Console.WriteLine(finanse1.Equals(finanse));
            Console.WriteLine();
            foreach (var item in FinanseFirmy.mapa.Values)
            {
                Console.WriteLine(item.NazwaMiesiaca +" " + item.Przychody);
               
            }
            

            Thread thread = new Thread(new ThreadStart(SingletonFunkcja));
            thread.Name = "Pierwszy";
            thread.IsBackground = true;
            thread.Start();
            Thread thread1 = new Thread(new ThreadStart(SingletonFunkcja));
            thread1.Name = "Drugi";
            thread1.IsBackground = true;
            thread1.Start();
            Console.WriteLine("Zaczynamy");
            SingletonFunkcja();
            Console.ReadKey();
        }

        private static void SingletonFunkcja()
        {
            Thread thread = Thread.CurrentThread;
            Zad4_Wspolbiezny.Singleton singleton;
            singleton = Zad4_Wspolbiezny.Singleton.GetInstance();
            for (int i = 0; i < 4; i++)
            {
                singleton.ZwiekszLiczbe++;
                Console.Write(singleton.ZwiekszLiczbe+" ");
                Console.WriteLine(thread.Name);
            }
        }
    }
}
