using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, r;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            // Para chamar um método estático, basta colocar o nome da classe e o nome do método
            r = Util.menorDentreTres(x, y, z);
            Console.WriteLine($"Menor: {r}");

            Console.ReadLine();
        }
    }
}
