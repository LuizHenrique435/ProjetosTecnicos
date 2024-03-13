using System;

namespace ExemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Viciado em OIs");
            int cont = 1;
            while (cont <= 100)
            {
                System.Console.WriteLine(cont + " Oi");
                cont = cont + 1;
            }

            Console.WriteLine("\n\n\n\nTabuada");
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int multiplicador = 1;
            while (multiplicador <= 10)
            {
                Console.WriteLine(multiplicador + " x " + num + " = " + (multiplicador * num));
                multiplicador = multiplicador + 1;
            }
        }
    }
}
