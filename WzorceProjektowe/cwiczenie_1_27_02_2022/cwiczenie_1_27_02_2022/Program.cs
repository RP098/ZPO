using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_1_27_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            RachunekBankowy saver1 = new RachunekBankowy(2000);
            RachunekBankowy saver2 = new RachunekBankowy(3000);
            RachunekBankowy.setROcznaStopaProcentowa(0.4);
            saver1.obliczMiesieczneOdsetki();
            saver2.obliczMiesieczneOdsetki();
            Console.WriteLine(saver1.getSaldo());
            Console.WriteLine(saver2.getSaldo());
            Console.ReadLine();
        }
    }
}
