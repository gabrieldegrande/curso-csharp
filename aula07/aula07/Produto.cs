using System.Globalization;

namespace curso
{
    class Produto
    {
        // private por padrão
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }
        public Fornecedor fornecedor { get; private  set; }
        // Podem ser acessados, mas não alterados 

        public Produto(string nome, double preco, int estoque, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = estoque;
            this.fornecedor = fornecedor;
        }

        public Produto(string nome, double preco, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = 0;
            this.fornecedor = fornecedor;
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
            return $"{nome}, R${preco.ToString("F2", CultureInfo.InvariantCulture)}, {quantidadeEmEstoque} unidades, Total: R${valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}, Fornecedor: {fornecedor}";
        }
    }
}