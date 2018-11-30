using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso possui quantos alunos? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for(int i=0; i < N; i++)
            {
                int aux = int.Parse(Console.ReadLine());
                A.Add(aux);
            }

            Console.WriteLine();
            Console.Write("O curso possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for(int i=0; i < N; i++)
            {
                int aux = int.Parse(Console.ReadLine());
                B.Add(aux);
            }

            Console.WriteLine();
            Console.Write("O curso possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for(int i=0; i < N; i++)
            {
                int aux = int.Parse(Console.ReadLine());
                C.Add(aux);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine($"Total de Alunos: {Novo.Count}");
            


            Console.ReadKey();
        }
    }
}
