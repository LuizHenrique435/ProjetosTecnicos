using System;

namespace Atividade1__NumerosInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Olá, informe o primeiro número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número !");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número !");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O maior número é o :" + n1);
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine("O maior número é o :" + n2);
                }
                else
                {
                    Console.WriteLine("O maior número é o :" + n3);
                }
            }

            Console.ReadKey();

        }
    }
}
