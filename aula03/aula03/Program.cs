using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            double soma, media;
            soma = 0.0;
            int N;
            Console.Write("Número de produtos: ");
            N = int.Parse(Console.ReadLine());

            vet = new Produto[N];                  // Instância o vetor de produto com N posições

            for(int i=0; i < N; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);  // Insância cada elemento 
                soma = soma + vet[i].preco;
            }
            media = soma / N;
            
            Console.WriteLine($"Preço médio: R${media.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}