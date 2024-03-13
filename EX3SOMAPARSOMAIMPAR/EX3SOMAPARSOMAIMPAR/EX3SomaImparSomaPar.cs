using System;

namespace EX3SOMAPARSOMAIMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, Cont = 0, SomaPar = 0, SomaImpar = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("**************************");
            Console.WriteLine("******SOMA DOS NÚMEROS****");
            Console.WriteLine("**************************");

            Console.WriteLine("Insira 10 números inteiros positivos ");

            while (Cont < 10)
            {
                Console.WriteLine("Insira os números");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero % 2 == 0)
                {
                    SomaPar = numero + SomaPar;
                }
                else
                {
                    SomaImpar = numero + SomaImpar;
                }
                Cont++;
            }

            Console.WriteLine("A soma dos números pares é igual a : " + SomaPar);
            Console.WriteLine("A soma dos números impares é igual a : " + SomaImpar);

            Console.ReadKey();
        }
    }
}
