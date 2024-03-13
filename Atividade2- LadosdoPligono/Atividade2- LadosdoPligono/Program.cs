using System;

namespace Atividade2__LadosdoPligono
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodelados;
            int b, h;

            Console.WriteLine("Informe o numero de lados");
            numerodelados = Convert.ToInt32(Console.ReadLine());

            if (numerodelados == 3)
            {
                Console.WriteLine("Triângulo");
                Console.WriteLine("informe a medida da base");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("informe a altura");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A área do triângulo é igual a:" + ((b*h)/2));
            }
           
            if (numerodelados == 4)
            {
                Console.WriteLine("Quadrado");
                Console.WriteLine("informe a altura do quadrado");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A área do quadrado é igual a:" + (h*h));
            }
            if (numerodelados == 5) Console.WriteLine("Pentágono");
            if (numerodelados < 3) Console.WriteLine("NÃO É UM POLÍGONO");
            if (numerodelados > 5) Console.WriteLine("POLÍGONO NÃO IDENTIFICADO");

            Console.ReadKey();
        }
    }
}
