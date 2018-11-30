using System.Globalization;

namespace curso
{
    class Produto
    {
        // private por padrão
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }
        // Podem ser acessados, mas não alterados

        public Produto(string nome, double preco, int estoque)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = estoque;

        }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = 0;
        }

        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        public override string ToString()
        {
            return $"{nome}, R${preco.ToString("F2", CultureInfo.InvariantCulture)}, {quantidadeEmEstoque} unidades, Total: R${valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}