using System;

namespace Atividade1__TrianguloIsoscesles
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

           Console.WriteLine("Olá informe a primeira medida (lado 1)! ");
            A = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Informe a segunda medida (lado 2)");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a terceira medida (lado 3)");
            C = Convert.ToInt32 (Console.ReadLine());

            if (A == B)
            {
                if (B == C) Console.WriteLine("Equilátero");
                if (B != C) Console.WriteLine("Isósceles");
            }
            if (A != B)
            {
                if (B != C)
                {
                if (C != A) Console.WriteLine("Escaleno");
                }
                if (B == C) Console.WriteLine("Isósceles");
            }

            if (A == C)
            {
                if (B != C) Console.WriteLine("Isóceles");
            }




        }
    }
}
