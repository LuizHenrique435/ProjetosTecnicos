using System;
using System.Linq;

namespace ExemplosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 1000 };

            Array.Reverse(numeros);
            foreach (int p in numeros)
                Console.WriteLine(p);
            Console.WriteLine("O maior número é " + numeros.Max());
            Console.WriteLine("O menor número é " + numeros.Min());
            Console.WriteLine("A soma de todos os números é " + numeros.Sum());
            // double media = numeros.Average();
            Console.WriteLine("A média de todos os números é " + numeros.Average());
        }
    }
}
