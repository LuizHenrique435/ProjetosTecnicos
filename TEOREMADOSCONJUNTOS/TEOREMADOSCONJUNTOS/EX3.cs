using System;

namespace TEOREMADOSCONJUNTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            for (int conta = 0; conta < 10; conta++)
            {
                Console.WriteLine("GRUPO 1");
                Console.WriteLine("Informe um número !");
                vetor1[conta] = Convert.ToInt32(Console.ReadLine());
            }
             for(int contadnv = 0; contadnv < 10; contadnv++)
            {
                Console.WriteLine("GRUPO 2");
                Console.WriteLine("Informe um número !");
                vetor2[contadnv] = Convert.ToInt32(Console.ReadLine());
            }

             for(int mostra = 0; mostra < 10; mostra++)
            {
                Console.WriteLine("A união desses dois conjuntos é igual a : " + (vetor1[mostra] + " e " + vetor2[mostra]));
            }

            for(int mostrar = 0; mostrar < 10; mostrar++)
            {
                Console.WriteLine("A diferenca dos conjuntos é igual a : " + (vetor1[mostrar] != vetor2[mostrar]));
            }

            for(int S = 0; S < 10; S++)
            {
                Console.WriteLine("A intersecção dos conjuntos é igual a : " + (vetor1[S] == vetor2[S]));
            }

            Console.ReadLine();
        }
    }
}
