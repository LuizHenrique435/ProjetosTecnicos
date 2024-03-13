using System;

namespace ExemploVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[20];

            nomes[0] = "Chaves";
            nomes[1] = "Kiko";
            nomes[2] = "Dona Florinda";
            nomes[3] = "Bruxa do 71";
            nomes[4] = "Madruguinha";
            nomes[5] = "Luiz";
            nomes[6] = "Levi";
            nomes[7] = "Gabigol";
            nomes[8] = "Messi";
            nomes[9] = "CR7";
            nomes[10] = "Lewa";
            nomes[11] = "De Bruyne";
            nomes[12] = "Pedro";
            nomes[13] = "Neymar";
            nomes[14] = "Cleiton";
            nomes[15] = "Girafales";
            nomes[16] = "Vitinho";
            nomes[17] = "Marcos";
            nomes[18] = "juvena";
            nomes[19] = "Negueba";
            nomes[20] = "Marcelo";

            for (int posicao= 0; posicao < 21; posicao++)
            {
                Console.WriteLine(nomes[posicao]);
            }


            Console.WriteLine("Hello World!");


        }
    }
}
