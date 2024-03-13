using System;

namespace Atividade5_Entre20E90
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;

            Console.WriteLine("Olá usuário, informe um número por favor !");
            n1 = Convert.ToDouble(Console.ReadLine());

            if(n1 >= 20)
            {
                if (n1 <= 90)
                {
                    Console.WriteLine("Número correto");
                }
                else
                {
                    Console.WriteLine("Número completamente errado !");
                }
            }
            else
            {
                Console.WriteLine("Número errado !!"); 
            }
           
        }
    }
}
