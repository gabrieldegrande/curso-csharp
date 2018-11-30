using Exercicio1Refeito.dominio;
using System;
using System.Globalization;

namespace Exercicio1Refeito
{
    class Tela
    {
        //Classe responsável por obter operações que interagem com o usuário no modo console

        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produto");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opcao: ");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS");
            for(int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }

        public static void cadastrarProduto()
        {
            Console.WriteLine("DIGITE OS DADOS DO PRODUTO");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto P = new Produto(codigo, descricao, preco);
            Program.produtos.Add(P);
            Program.produtos.Sort();
        }

        public static void cadastrarPedido()
        {
            Console.WriteLine("DIGITE OS DADOS DO PEDIDO");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Pedido P = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Digite os dados do {i}º item");
                Console.Write("Código: ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.codigo == codProduto);
                if(pos == -1)
                {
                    throw new ModelException($"Não foi encontrado um produto com o código {codProduto}");
                }
                else
                {
                    Console.Write("Quantidade: ");
                    int qte = int.Parse(Console.ReadLine());
                    Console.Write("Porcentagem de desconto: ");
                    double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ItemPedido ip = new ItemPedido(qte, porcent, P, Program.produtos[pos]);
                    P.itens.Add(ip);
                }
            }
            Program.pedidos.Add(P);
        }

        public static void mostrarPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());

            int pos = Program.pedidos.FindIndex(x => x.codigo == codPedido);
            if(pos == -1)
            {
                throw new ModelException($"Não foi encontrado um pedido com o código {codPedido}");
            }
            Console.WriteLine(Program.pedidos[pos]);
            Console.WriteLine();
        }
    }
}
