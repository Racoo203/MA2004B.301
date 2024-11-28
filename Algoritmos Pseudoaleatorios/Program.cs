using System;
using Algoritmos_Pseudoaleatorios.Algoritmos;

namespace Algoritmos_Pseudoaleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador Congruencial Lineal:");
            CongruencialLineal congruencial = new CongruencialLineal(5, 3, 16, 7); // Example parameters
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {congruencial.Next()}");
            }

            Console.WriteLine("\nGenerador de Cuadrado Medio:");
            CuadradoMedio cuadradoMedio = new CuadradoMedio(1234); // Example seed
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {cuadradoMedio.Next()}");
            }
        }
    }
}
