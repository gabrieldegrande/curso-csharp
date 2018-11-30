using System;
using System.Collections.Generic;
using System.Globalization;

namespace E_xercicioLista
{
    class Funcionarios
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionarios(string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumento( double porcentagem)
        {
             salario = porcentagem * salario / 100.0 + salario;
        }

        public override string ToString()
        {
            return $"{cpf}, {nome}, R${salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
