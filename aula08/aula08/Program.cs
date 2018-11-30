using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Figura {i} - triângulo ou retângulo(t/r)?");
                char ch = char.Parse(Console.ReadLine());
                if(ch == 'r')
                {
                    Figura f = Tela.lerRetangulo();
                    lista.Add(f);
                }
                else
                {
                    Figura f = Tela.lerTriangulo();
                    lista.Add(f);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");
            for(int i=0; i<N; i++)
            {
                Console.WriteLine($"Figura {i+1} {lista[i].cor}: {lista[i].area()}");
            }

            Console.WriteLine();
            Console.WriteLine("Perimetro das figuras: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Figura {i + 1} {lista[i].cor}: {lista[i].perimetro()}");
            }


            Console.ReadKey();
        }
    }
}
