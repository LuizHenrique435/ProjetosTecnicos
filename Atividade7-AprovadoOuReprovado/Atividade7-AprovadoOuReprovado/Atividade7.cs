using System;

namespace Atividade7_AprovadoOuReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double nota1, nota2, nota3;
            int Faltas;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep();

            Console.WriteLine("Olá estudante, por favor informe seu nome !!");
            Nome = Console.ReadLine();

            Console.Beep();

            Console.WriteLine("Agora,por favor, informe a primeira nota !");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Beep();

            Console.WriteLine("A segunda nota por favor !");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Beep();

            Console.WriteLine("Finalmente informe a terceira e última nota !!");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Beep();

            Console.WriteLine("Agora informe o número de faltas !!");
            Faltas = Convert.ToInt32(Console.ReadLine());

            Console.Beep();
            Console.Beep();

            Console.WriteLine("A média foi igual a: " + ((nota1 + nota2 + nota3) /3 ));
            Console.WriteLine("O número de faltas que o estudante pode ter é: = 20");

            Console.Beep();

            if (Faltas > 20)
            {
                Console.WriteLine("REPROVADO !!!");
            }
            else
            {
                if((nota1+nota2+nota3)/3 >= 7.00)
                {
                    Console.WriteLine("APROVADO !!!");
                }
                else
                {
                    Console.WriteLine("REPROVADO !!!");
                }
            }

            Console.ReadKey();

        }
    }
}
