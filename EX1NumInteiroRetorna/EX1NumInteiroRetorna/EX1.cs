using System;
using System.Runtime.InteropServices;

namespace EX1NumInteiroRetorna
{
    class Program
    {
        static void Main(string[] args)
        {
            int numrecebido = 0;

            Console.WriteLine("Por favor insira um número inteiro, e o computador mostrará todos os números pares até o número digitado !");
            numrecebido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pressione ENTER !");
            Console.ReadLine();

            for (int sequencia = 0; sequencia < numrecebido; sequencia = sequencia + 1)
            {
                if (sequencia % 2 == 0)
                {
                    Console.WriteLine("Pares : " + sequencia);
                }
                else
                {
                    Console.WriteLine("Impares : " + sequencia);
                }
            }

            Console.ReadKey();
        }
    }
}
