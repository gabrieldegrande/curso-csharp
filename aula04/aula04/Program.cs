using System;


namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int N, cont;
            cont = 0;

            Console.Write("Digite as dimensões da matriz: ");
            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for(int i=0; i<N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            Console.WriteLine("Diagonal Pricipal: ");
            for(int i=0; i<N; i++)
            {
                Console.Write($"{mat[i, i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Quantidade de negativos: ");
            
            for (int i = 0; i < N; i++){
                for (int j = 0; j < N; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine($"{cont}");

            Console.ReadKey();
        }
    }
}
