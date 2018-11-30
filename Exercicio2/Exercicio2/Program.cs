using Exercicio2.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        public static List<Artistas> artistas = new List<Artistas>();
        public static List<Filme> filme = new List<Filme>();

        static void Main(string[] args)
        {
            int opcao = 0;

            artistas.Add(new Artistas(101, "Scarlet Johansson", 4000000.00));
            artistas.Add(new Artistas(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artistas(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artistas(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();
            
            while(opcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }catch(Exception e)
                {
                    Console.WriteLine($"Erro inesperado: {e.Message}");
                    opcao = 0;
                }
                Console.WriteLine();

                if(opcao == 1)
                {
                    Tela.mostrarArtistas();
                }
                else if (opcao == 2)
                {
                    try
                    {
                        Tela.cadastrarArtista();
                    }catch(Exception e)
                    {
                        Console.WriteLine($"Erro inesperado: {e}");
                    }
                }else if (opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarFilme();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine($"Erro de negócio: {e}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro inesperado: {e}");
                    }
                }else if (opcao == 4)
                {
                    try
                    {
                        Tela.mostrarFilme();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine($"Erro de negócio: {e}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro inesperado: {e}");
                    }
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Fim do Programa!");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            Console.ReadKey();
            }
        }
    }
}
