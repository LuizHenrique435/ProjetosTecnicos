using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];
            int Qtdimpares = 0;
            int Qtdpares = 0;

            for (int posicao = 0; posicao < 10; posicao++)
            {

                Console.WriteLine("Insira um número");
                numeros[posicao] = Convert.ToInt32(Console.ReadLine());

                if (numeros[posicao] % 2 == 0)
                {
                    Qtdpares = Qtdpares + 1;
                    pares[Qtdpares] = numeros[posicao];


                }
                else
                {
                    Qtdimpares = Qtdimpares + 1;
                    impares[Qtdimpares] = numeros[posicao];

                }

            }

            Array.Sort(pares);
            Array.Sort(impares);

            Console.WriteLine("\nOs numeros pares ordenados são:");


            for (int Luiz = 0; Luiz < 10; Luiz = Luiz + 1)
            {

                Console.WriteLine(pares[Luiz]);

            }


            Console.WriteLine("\nOs numeros impares ordenados são:");


            for (int Luiz2 = 0; Luiz2 < 10; Luiz2 = Luiz2 + 1)
            {

                Console.WriteLine(impares[Luiz2]);

            }

            Console.ReadLine();
        }
    }
}
