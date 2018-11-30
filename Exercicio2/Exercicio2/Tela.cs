using System;
using System.Globalization;

namespace Exercicio2.dominio
{
    class Tela
    {
        //Classe responsável por obter operações que interagem com o usuário no modo console

        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
        }

        public static void mostrarArtistas()
        {
            Console.WriteLine("LISTAGEM DE ARTISTAS");
            for(int i = 0; i < Program.artistas.Count; i++)
            {
                Console.WriteLine(Program.artistas[i]);
            }
        }

        public static void cadastrarArtista()
        {
            Console.WriteLine("Digite os dados do artista");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do Cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Artistas P = new Artistas(codigo, nome, cache);
            Program.artistas.Add(P);
            Program.artistas.Sort();
        }

        public static void cadastrarFilme()
        {
            Console.WriteLine("DIGITE OS DADOS DO FILME");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Filme f = new Filme(codigo, titulo, ano);

            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Digite os dados da {i}ª participação");
                Console.Write("Artista(código): ");
                int codArt = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == codArt);
                if(pos == -1)
                {
                    throw new ModelException($"Não foi encontrado um artista com o código {codArt}");
                }
                else
                {
                    Console.Write("Desconto: ");
                    double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Participacao pt = new Participacao(Program.artistas[pos], desconto);
                    f.parts.Add(pt);
                }
            }
            Program.filme.Add(f);
        }
        public static void mostrarFilme()
        {
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());

            int pos = Program.filme.FindIndex(x => x.codigo == codFilme);
            if(pos == -1)
            {
                throw new ModelException($"Não foi encontrado um filme com o código {codFilme}");
            }
            Console.WriteLine(Program.filme[pos]);
            Console.WriteLine();
        }
    }
}
