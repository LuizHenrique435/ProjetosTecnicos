using System;

namespace TainaVinicius
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaTaina = 1.70;
            double alturaVinicius = 1.50;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("****************");
            Console.WriteLine("Tainá X Vinicius");
            Console.WriteLine("****************");

            int ano = 1;

            inicio:

            while (ano <= 4)
            {
                Console.WriteLine("\n\n Ano " + ano + "\n");

                Console.WriteLine("A altura  de Tainá é igual a : " + alturaTaina);
                alturaTaina = alturaTaina;
                alturaTaina = alturaTaina + 0.10;

                Console.WriteLine("A altura de Vinicius é igual a : " + alturaVinicius + "\n\n");
                alturaVinicius = alturaVinicius;
                alturaVinicius = alturaVinicius + 0.20;

                ano++;
            }

            Console.WriteLine("Quer rever os resultados ? S/N");
            if (Console.ReadLine() == "s") goto inicio;

            Console.WriteLine("Ok, Tchau Brigado !");

        }
    }
}
