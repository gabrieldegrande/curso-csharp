using System.Globalization;

namespace curso
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public Produto(string nome, double preco, int estoque /* int quantidadeEmEstoque*/)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = estoque;

            // se o nome do parâmetro for igual ao da propriedade, deve-se usar o this.
            // this.quantidadeEmEstoque = quantidadeEmEstoque;
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