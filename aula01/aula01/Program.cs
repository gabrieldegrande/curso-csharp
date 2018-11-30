using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte;

            Console.WriteLine("Digite os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade em estoque: ");
            //int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            //Produto P = new Produto(nome, preco, quantidadeEmEstoque);
            Produto P = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade produtos que sairam do estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + P);

            Console.ReadKey();
        }
    }
}
