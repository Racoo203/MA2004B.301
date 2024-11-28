using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Pseudoaleatorios.Algoritmos
{
    public class CuadradoMedio
    {
        private int seed;
        private int numDigits;

        public CuadradoMedio(int seed)
        {
            this.seed = seed;
            numDigits = seed.ToString().Length;
        }

        public int Next()
        {
            int squared = seed * seed;
            string squaredStr = squared.ToString("D" + numDigits * 2);
            int start = (squaredStr.Length - numDigits) / 2;
            seed = int.Parse(squaredStr.Substring(start, numDigits));
            return seed;
        }
    }

}
