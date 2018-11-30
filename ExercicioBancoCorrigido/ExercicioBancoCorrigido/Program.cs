using System;
using System.Globalization;

namespace ExercicioBancoCorrigido
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;
            double valor;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá um depósito inicial(s/n)? ");
            char ch = char.Parse(Console.ReadLine());

            if(ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else
            {
                x = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta criada:");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite o valor para depositar:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(valor);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite o valor para sacar:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(valor);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
