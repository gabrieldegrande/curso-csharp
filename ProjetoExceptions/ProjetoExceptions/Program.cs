using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de Saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta x = new Conta(numero, titular, limiteDeSaque);
            Console.WriteLine();

            Console.WriteLine(x); 
            Console.WriteLine();

            Console.Write("Digite o valor para depositar: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(valor);
            Console.WriteLine($"Novo saldo: {x.saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Digite o valor para sacar: ");
            valor = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            try { 
                x.sacar(valor);
                Console.WriteLine($"Novo saldo: {x.saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }

            //Console.WriteLine("Conta Atualizada: ");
            //Console.WriteLine(x);

            Console.ReadKey();  
        }
    }
}
