using System;

namespace MenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            int posicao = 0;
            Console.WriteLine("Digite a quantidade de elemetos:");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];
            string[] numeros = Console.ReadLine().Split(' ');
            for (int i=0; i< n; i++)
            {
                vet[i] = int.Parse(numeros[i]);
            }
            for (int i = 0; i <n; i++)
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                    posicao = i;
                }
                else if (i == 0)
                {
                    menor = vet[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Posição: "+ posicao);
        }
    }
}
