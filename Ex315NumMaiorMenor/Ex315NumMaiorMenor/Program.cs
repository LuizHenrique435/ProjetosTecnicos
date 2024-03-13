using System;

namespace Ex315NumMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {

            int numdigitado = 0;
            int maiornumero = 0;
            int menornumero = 0;

            Console.WriteLine("INSIRA OS 15 NÚMEROS O SISTEMA IRÁ O MAIOR E O MENOR:");

            Console.WriteLine("Insira alguns números : ");
            numdigitado = Convert.ToInt32(Console.ReadLine());

            maiornumero = numdigitado;
            menornumero = numdigitado;

            for (int cont = 0; cont < 15; cont = cont + 1)
            {
                Console.WriteLine("Insira mais   números:");
                numdigitado = Convert.ToInt32(Console.ReadLine());


                if (numdigitado > maiornumero)
                {
                    maiornumero = numdigitado;
                }

                if (numdigitado < menornumero)
                {
                    menornumero = numdigitado;
                }
            }

            Console.WriteLine("O maior numero inserido foi: " + maiornumero);
            Console.WriteLine("O menor numero inserido foi: " + menornumero);

            Console.ReadLine();
        }
    }
}
