using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Silownia : ISpedzanieWolnegoCzasu
    {
        public void spedzajWolnyCzas()
        {
            Console.WriteLine("Ćwiczę na siłowni");
        }
    }
}
