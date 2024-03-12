using System;

namespace _5NumerosPerfeitos
{
    class Program
    {
        static void Main(string[] args)
        { 

            double num = 2, resto1, resto2, resto3;

            Console.WriteLine("Pressione a tecla I para iniciar");
            Console.ReadKey();

            for (int repeticao = 1; repeticao <= 5; repeticao++)
            {
            inicio:
                int div = 0;

                for (int repete = 1; repete <= num; repete++)
                {
                    if (num % repete == 0)
                    {
                        div++;
                    }
                }
                //11 é primo, porém não gera número perfeito//
                if (num == 11)
                {
                    num++;
                    goto inicio;
                }
                //HORA DA PERFEIÇÃO//
                if (div == 2)
                {
                    resto1 = Math.Pow(2, num - 1);
                    resto2 = Math.Pow(2, num) - 1;
                    resto3 = resto1 * resto2;
                    Console.WriteLine(resto3);
                }
                else
                {
                    num ++;
                    goto inicio;
                }
                num ++;
            }

        }
    }
}
