using System;

namespace EX1Multiplos235
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =0;
            string mults2 = "", mults3 = "", mults5= "";
            

            for (int cont = 1; cont <= num; cont++) ;

            Console.WriteLine("Olá digite um número !");
            Console.WriteLine("A aplicação retornará todos os multiplos de 2, 3 e 5 até o número digitado por você !");
            num = Convert.ToInt32(Console.ReadLine());

            for(int passador =0; passador <= num; passador++)
            {
                if (passador % 2 == 0) mults2 = mults2 + " " + passador;
                if (passador % 3 == 0) mults3 = mults3 + " " + passador;
                if (passador % 5 == 0) mults5 = mults5 + " " + passador;
            }

            Console.WriteLine("Multiplos de 2 : " + mults2);
            Console.WriteLine("Multiplos de 3 : " + mults3);
            Console.WriteLine("Multiplos de 5 : " + mults5);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
