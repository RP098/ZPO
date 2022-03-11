using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_1_27_02_2022
{
    class RachunekBankowy
    {
        static double rocznaStopaProcentowa;
        private double saldo;
        public RachunekBankowy():this(0)
        {

        }
        public RachunekBankowy(double saldo)
        {
            this.saldo = saldo;
        }
        public void obliczMiesieczneOdsetki()=>saldo+=rocznaStopaProcentowa*saldo/12;
        public static void setROcznaStopaProcentowa(double rocznaStopaProcentowa)
        {
            RachunekBankowy.rocznaStopaProcentowa = rocznaStopaProcentowa;
        }
        public double getSaldo()=> this.saldo;
        

    }
}
