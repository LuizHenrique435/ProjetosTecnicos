using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomedoestudante;
            string materia;
            double prova1;
            double prova2;
            double prova3;

            Console.WriteLine("informe o nome do estudante");
            nomedoestudante = Console.ReadLine();

            Console.WriteLine("informe a materia");
            materia = Console.ReadLine();
            Console.WriteLine("informe a nota da prova1");
            prova1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota da prova2");
            prova2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a nota da prova3");
            prova3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média desse estudante é");
            Console.WriteLine(((+prova1 + prova2 + prova3) / 3));

            Console.ReadKey();



        }
    }
}
