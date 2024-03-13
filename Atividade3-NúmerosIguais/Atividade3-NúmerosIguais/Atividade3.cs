using System;

namespace Atividade3_NúmerosIguais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Olá usuário, informe o primeiro número !");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora, informe o segundo número !");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 > n2)
            {
                Console.WriteLine("O maior número é o : " + n1);
            }
            else
            {
                if (n1 == n2)
                {
                    Console.WriteLine("NÚMEROS IGUAIS " + n1 + " e o " + n2);
                }
                else
                {
                    Console.WriteLine("O maior número é o :" + n2);
                }
            }
        }
    }
}
