using System.Globalization;

namespace ExercicioBanco
{
    class ContaBancaria
    {
        public int nConta { get; private set; }
        public string nomeTitular;
        private double saldo;
        
        public ContaBancaria(int nConta, string nomeTitular, double saldo)
        {
            this.nConta = nConta;
            this.nomeTitular = nomeTitular;
            this.saldo = saldo;
        }


        public ContaBancaria(int nConta, string nomeTitular)
        {
            this.nConta = nConta;
            this.nomeTitular = nomeTitular;
            saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void sacar(double valor)
        {
            saldo -= valor + 5.00;
        }


        public override string ToString()
        {
            return $"Conta: {nConta}, Titular: {nomeTitular}, Saldo: R${saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}