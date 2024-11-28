using System;
using Algoritmos_Pseudoaleatorios.Algoritmos;

namespace Algoritmos_Pseudoaleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador Congruencial Lineal:");

            // Solicita valores al usuario con valores predeterminados
            int a = GetInputOrDefault("Introduce el valor de 'a' (default: 5): ", 5);
            int c = GetInputOrDefault("Introduce el valor de 'c' (default: 3): ", 3);
            int m = GetInputOrDefault("Introduce el valor de 'm' (default: 16): ", 16);
            int seedCL = GetInputOrDefault("Introduce la semilla inicial (default: 7): ", 7);

            CongruencialLineal congruencial = new CongruencialLineal(a, c, m, seedCL);

            Console.WriteLine("\nValores generados por el Generador Congruencial Lineal:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {congruencial.Next()}");
            }

            Console.WriteLine("\nGenerador de Cuadrado Medio:");

            // Solicita la semilla para el método de cuadrados medios
            int seedCM = GetInputOrDefault("Introduce la semilla inicial para Cuadrado Medio (default: 1234): ", 1234);

            CuadradoMedio cuadradoMedio = new CuadradoMedio(seedCM);

            Console.WriteLine("\nValores generados por el Generador de Cuadrado Medio:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor {i + 1}: {cuadradoMedio.Next()}");
            }

        }

        /// <summary>
        /// Obtiene la entrada del usuario o utiliza un valor predeterminado si no se proporciona.
        /// </summary>
        static int GetInputOrDefault(string prompt, int defaultValue)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            // Si no se escribe nada, retorna el valor predeterminado
            if (string.IsNullOrWhiteSpace(input))
            {
                return defaultValue;
            }

            // Intenta convertir el input a entero
            if (int.TryParse(input, out int result))
            {
                return result;
            }

            // Si no se puede convertir, retorna el valor predeterminado
            Console.WriteLine($"Entrada no válida. Se usará el valor predeterminado: {defaultValue}");
            return defaultValue;
        }
    }
}