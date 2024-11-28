using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Pseudoaleatorios.Algoritmos
{
    public class CongruencialLineal
    {
        private int a, c, m;
        private int seed;

        public CongruencialLineal(int a, int c, int m, int seed)
        {
            this.a = a;
            this.c = c;
            this.m = m;
            this.seed = seed;
        }

        public int Next()
        {
            seed = (a * seed + c) % m;
            return seed;
        }
    }

}
