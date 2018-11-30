using System.Globalization;

namespace ProjetoExceptions
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }
        public double limiteDeSaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeSaque = limiteDeSaque;
            saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void sacar(double valor)
        {
            if (saldo < valor)
            {
                throw new OperacaoException ("Não há saldo sufciente! Operação cancelada.");
            }
            if (valor > limiteDeSaque)
            {
                throw new OperacaoException("Valor de saque é maior que o limite da conta! Operação Cancelada.");
            }
            saldo -= valor;
        }

        public override string ToString()
        {
            return $"Número da conta: {numero}, Titular: {titular}, " +
                $"Limite de Saque: {limiteDeSaque.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
