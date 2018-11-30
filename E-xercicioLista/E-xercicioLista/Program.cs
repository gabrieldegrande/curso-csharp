using System;
using System.Collections.Generic;
using System.Globalization;

namespace E_xercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> lista = new List<Funcionarios>();

            Console.Write("Quantos funcionários serão cadastrados? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Dados do {i}º funcionário");
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionarios f = new Funcionarios(cpf, nome, salario);
                lista.Add(f);

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            string cpfBuscado = Console.ReadLine();
            int pos = lista.FindIndex(x => x.cpf == cpfBuscado);
            if (pos == -1)
            {
                Console.WriteLine("CPF inexistente!");
            }
            else
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].aumento(porc);
            }


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }


            Console.ReadKey();
        }
    }
}
