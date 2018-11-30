using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluguel
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vet = new Aluguel[10];

            Console.Write("Quantos aluguéis serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            for(int i=0; i<N; i++)
            {
                Console.WriteLine($"Dados do {i+1}º aluguel:");
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Email: ");
                string email = Console.ReadLine();
                Console.Write($"Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Aluguel(nome, email);

                Console.WriteLine();
            }
            
            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");
            for(int i=0; i<10; i++) 
            { 
                if(vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
