using System;

namespace NumerosMaioresEMenores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Informe o primeiro número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número !");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine("O maior número é o :" + n1);
            }
            else
            {
                Console.WriteLine("O maior número é o :" + n2);
            }

            Console.ReadKey();
        }
    }
}
