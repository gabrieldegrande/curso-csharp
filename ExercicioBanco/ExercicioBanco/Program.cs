using System;

using System.Globalization;


namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;
            double valor;

            Console.Write("Número da conta: ");
            int nConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial(s/n)?");
            char depositoInicial = char.Parse(Console.ReadLine());

            if (depositoInicial == 's')
            {
                Console.Write("Digite o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(nConta, nomeTitular, valorInicial);
            }
            else
            {
                cb = new ContaBancaria(nConta, nomeTitular);
            }
            
            Console.WriteLine();
            Console.WriteLine("Conta Criada:");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.depositar(valor);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para sacar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.sacar(valor);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada: ");
            Console.WriteLine(cb);

            Console.ReadKey();

        }
    }
}
