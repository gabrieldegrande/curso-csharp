using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Lojas Ltda", "lojas@gmail.com", "1234566");
            Produto p = new Produto("TV", 1000.00, f);

            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
