using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4_Wspolbiezny
{
    public class Singleton
    {
        static Singleton singleton;
        private Singleton()
        {
            
        }
        public int ZwiekszLiczbe { get; set; } = 0;

       public static  Singleton  GetInstance( )
        {
            if (Singleton.singleton == null)
                Singleton.singleton = new Singleton();
            lock (singleton)
            {
                if (Singleton.singleton == null)
                {
                    Singleton.singleton = new Singleton();
                    return Singleton.singleton;
                }
                else
                {
                    return Singleton.singleton;
                }
            }
        }

    }
}
