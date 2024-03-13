using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdMacas;

            Console.WriteLine("Quantas maças foram compradas ?");
            qntdMacas = Convert.ToInt32(Console.ReadLine());

            if (qntdMacas < 12)
            {
                Console.WriteLine("O total a ser pago (R$ 0,30):" + (qntdMacas * 0.30));
            }
            else
            {
                Console.WriteLine("O total a ser pago (R$ 0,25):" + (qntdMacas * 0.25));
            }


            /******************ALTERNATIVA*******************/

            if (qntdMacas < 12) Console.WriteLine("O total a ser pago é (R$ 0,30):" + (qntdMacas * 0.30));
            if (qntdMacas > 12) Console.WriteLine("O total a ser pago é (R$ 0,25):" + (qntdMacas * 0.25));

            Console.ReadKey();
        }
    }
}
