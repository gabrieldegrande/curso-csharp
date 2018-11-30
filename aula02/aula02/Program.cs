using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Produto P = new Produto(nome, preco, quantidadeEmEstoque);
            Produto P2 = P;
            Console.WriteLine(P);
            Console.WriteLine(P2);

            /*
            Ponto A = new Ponto();
            Ponto B = new Ponto();

            A.x = 10;
            A.y = 50;

            B = A;
            B.y = 30;

            Console.WriteLine(A);
            Console.WriteLine(B);
            */

            Console.ReadKey();
        }
    }
}