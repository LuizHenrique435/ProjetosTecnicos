using System;

namespace Ex220Par
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numrecebido = 0;
            string ListaPar = " ";

            Console.WriteLine("Hello Word");

            for (int contador = 0; contador <= 20; contador = contador + 1)
            {

                Console.WriteLine("Informe vinte números:");
                Numrecebido = Convert.ToInt32(Console.ReadLine());

                if (Numrecebido % 2 == 0)
                {
                    ListaPar = ListaPar + " " + Numrecebido;
                }
            }

            Console.WriteLine("Números pares:" + ListaPar);

            Console.ReadLine();
        }
    }
}
