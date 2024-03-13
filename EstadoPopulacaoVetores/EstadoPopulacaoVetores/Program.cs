using System;

namespace EstadoPopulacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] estados = new String[5];
            int[] populacao = new int[5];
            int Total = 0;

            // OBS. o comando Length retorna o tamanho do vetor.
            for (int posicao = 0; posicao < estados.Length; posicao++)
            {
                Console.WriteLine("Informe o nome do Estado " + posicao + ":");
                estados[posicao] = Console.ReadLine();
                Console.WriteLine("Informe a população do Estado " + estados + ":");
                populacao[posicao] = Convert.ToInt32(Console.ReadLine());
            }
            for (int posicao = 0; posicao < estados.Length; posicao++)
            {
                Console.WriteLine(estados[posicao] + ", população de " + populacao[posicao]);
                Total = Total + populacao[posicao];
            }
            Console.WriteLine("Total da população do Brasil: " + Total);
        }
    }
}
