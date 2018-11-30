using System;
using System.Collections.Generic;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("João");
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("José");

            for(int i=0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
            
            lista.Remove("Maria");                          // ou lista.RemoveAt(1);
            int pos = lista.FindIndex(x => x == "José");    // encontrar o index de x onde x == "josé" e salvar na variável 'pos'

            Console.WriteLine($"Após remover o nome Maria, a posição de José é: {pos}");
            Console.WriteLine();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            
            List<Produto> prod = new List<Produto>();
            prod.Add(new Produto("TV", 900.00));
            prod.Add(new Produto("Aspirador", 500.00));
            prod.Add(new Produto("Geladeira", 2000.00));
            Console.WriteLine();
            
            int posicao = prod.FindIndex(x => x.nome == "Aspirador");
            Console.WriteLine($"Posição encontrada: {posicao}");
            Console.WriteLine();

            int posicao2 = prod.FindIndex(x => x.preco > 1000.00); // exibe o primeiro elemento que atende ao critério de busca
            Console.WriteLine($"Posição encontrada: {posicao2}");
            Console.WriteLine();

            int posicao3 = prod.FindIndex(x => x.preco < 1000.00); // exibe o primeiro elemento que atende ao critério de busca
            Console.WriteLine($"Posição encontrada: {posicao3}");
            Console.WriteLine();

            int posicao4 = prod.FindIndex(x => x.preco > 3000.00); // caso nenhum dos elementos atenda aos critérios, exibirá -1
            Console.WriteLine($"Posição encontrada: {posicao4}");
            Console.WriteLine();

            // OU
            Console.WriteLine($"{prod.Find(x => x.nome == "TV")}");
            Console.WriteLine();
            Console.WriteLine($"Posição encontrada: {prod.FindIndex(x => x.nome == "TV")}");
            Console.WriteLine();

            for (int i = 0; i < prod.Count; i++)
            {
                Console.WriteLine(prod[i]);
            }


            Console.ReadKey();
        }
    }
}
