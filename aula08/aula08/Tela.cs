using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula08
{
    class Tela
    {
        public static Triangulo lerTriangulo()
        {
            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine());
            return new Triangulo(a, b, c, "azul");
        } 

        public static Retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine());
            return new Retangulo(largura, altura, "preto");
        }

    }
}
