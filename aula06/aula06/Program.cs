using System;
using System.Collections.Generic;


namespace aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(4); // Conjuntos não permitem repetição, portanto, não adicionará outro elemento com o valor 4
            B.Add(5);

            //B.Remove(4);  Remove o elemento 4

            //A.ExceptWith(B);      DIFERENÇA  - Remove os elementos de A que existirem em B
            //A.UnionWith(B);       UNIÃO      - Adiciona em A, os elementos de B que não existem em A
            //A.IntersectWith(B);   INTERSEÇÃO - Exibe os elementos que estão presentes nos dois conjuntos

            foreach(int x in A)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }




            Console.Write("digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine($"{N} pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine($"{N} não pertence ao conjunto B");
            }

            Console.ReadKey();
        }
    }
}
