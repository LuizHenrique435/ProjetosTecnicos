using System;

namespace ExemploTabuadaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("\n\nUsando WHILE");
            int contador = 0;
            
            while (contador <= 10)
            {
                Console.WriteLine("2 x " + contador + " = " + 2 * contador); 
                
                contador++;
            }

            Console.WriteLine("\n\nAgora usando FOR");

            for (int contador2 = 0; contador2 <= 10; contador2++)
            {
                  Console.WriteLine("2 x " + contador2 + " = " + 2 * contador2); 
            }
        }
    }
}
