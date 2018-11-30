using System;
using System.Globalization;

namespace ExercicioBancoCorrigido
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular;
        private double saldo;

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0.0;
        }

        public void depositar(double valor)
        {
             saldo += valor;
        }

        public void sacar(double valor)
        {
             saldo -= (valor + 5.00);
        }

        public override string ToString()
        {
            return $"Conta: {numero}, Titular: {titular}, Saldo R${saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
