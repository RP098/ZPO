using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie_1_27_02_2022
{
    class IntegerSet
    {
       
        public bool[] zbiorWartosc = new bool[100];
        public int[] liczbyInteger = new int[100];
        public IntegerSet()
        {

        }
      
        public static int[] setUnion(int[] liczby_set, int[] liczby_set_2)
        {
            var liczby_set_3 = liczby_set.Union(liczby_set_2).ToArray<int>();
            return liczby_set_3;
        }

        public static int [] interSection(int[] liczby_set, int[] liczby_set_2)
        {
            var liczby_set_3 = liczby_set.Intersect(liczby_set_2).ToArray<int>();
            return liczby_set_3;
        }

        public void insert(int dodajLiczbe)
        {
            this.liczbyInteger
        }
    }
}
