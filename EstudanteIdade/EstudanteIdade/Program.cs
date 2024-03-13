using System;
using System.Data;

namespace EstudanteIdade
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Nomes = new string[10];
            int[] Idades = new int[10];

            for (int contador = 0; contador < Nomes.Length; contador++)
            {
                Console.WriteLine("Informe seu nome !");
                Nomes[contador] = Console.ReadLine();

                Console.WriteLine("Agora informe sua respectiva idade !");
                Idades[contador] = Convert.ToInt16(Console.ReadLine());

            }

            Array.Sort(Nomes);
            Array.Sort(Idades);

            Console.WriteLine("Os nomes ordenados são : ");
             
            for(int orderna = 0; orderna < Nomes.Length; orderna++)
            {
                Console.WriteLine(Nomes[orderna]);
            }

        }
    }
}
