using System;

namespace Atividade2Numeros
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

            if (n1 > n2)
            {
                Console.WriteLine("Número maior é o :" + n1);
            }
            else
            {
                if (n1 == n2)
                {
                    Console.WriteLine("Números iguais :" + n1 + " e o " + n2);
                }
                else
                {
                    Console.WriteLine("O número maior é :" + n2);
                }

                Console.ReadKey();
            }
        }
    }
}
