using System;

namespace Ex2FORInfinito
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu;

            Console.WriteLine("Hello Word");

            for (int contador = 0; contador < 10;)
            {
                Console.WriteLine("INSIRA UM NÚMERO E SEJA FELIZ");
                Console.WriteLine("OBS : Digite um número para a lista infinita *DESCUBRA O CÓDICO*");
                nu = Convert.ToInt32(Console.ReadLine());
                if (nu == 99999)
                {
                    contador = contador + 200;
                }
            }

            Console.WriteLine("OOOOUUUUUU VOCÊ É BRABO DMS IGUAL O XANDÃO, PARABENS VOCÊ DESCOBRIU O CÓDIGO SECRETO, VOCÊ GANHOU 1.000.000.000.000.000");
            Console.ReadLine();
        }
    }
}
