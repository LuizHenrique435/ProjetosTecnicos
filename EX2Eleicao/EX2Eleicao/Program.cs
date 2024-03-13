using System;

namespace EX2Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores = 1, voto = 0;
            int totalCandidato1 = 0, totalCandidato2 = 0, totalCandidato3 = 0, totalCandidato4 = 0;
            int totalBranco = 0, totalNulo = 0;

            Console.WriteLine("ELEIÇÃO");
            
            while (eleitores <= 15)
            {
                Console.WriteLine("Eleitor nº " + eleitores + ", por favor escolha um candidado:");
                Console.WriteLine("1. Marcelo\n2. Pedro B\n3. Taina\n4. Artur");
                Console.WriteLine("5. Branco\n6. Nulo");

                voto = Convert.ToInt16(Console.ReadLine());

                if (voto == 1) totalCandidato1++;
                if (voto == 2) totalCandidato2++; 
                if (voto == 3) totalCandidato3++; 
                if (voto == 4) totalCandidato4++;
                if (voto == 5) totalBranco++;
                if (voto == 6) totalNulo++;

                eleitores++;
            }

            Console.WriteLine("\n********************************");
            Console.WriteLine("RESULTADO");
            Console.WriteLine("********************************");
            Console.WriteLine("Marcelo: " + totalCandidato1 + " (" + (totalCandidato1 * 100) / 15 + "%)"); 
            Console.WriteLine("Pedro B: " + totalCandidato2 + " (" + (totalCandidato2 * 100) / 15 + "%)");
            Console.WriteLine("Taina: " + totalCandidato3 + " (" + (totalCandidato3 * 100) / 15 + "%)"); 
            Console.WriteLine("Artur: " + totalCandidato4 + " (" + (totalCandidato4 * 100) / 15 + "%)");
            Console.WriteLine("Brancos: " + totalBranco + " (" + (totalBranco * 100) / 15 + "%)"); 
            Console.WriteLine("nulos: " + totalNulo + " (" + (totalNulo * 100) / 15 + "%)");
        }
    }
}
