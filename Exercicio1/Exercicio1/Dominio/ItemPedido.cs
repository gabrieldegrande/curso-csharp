using Exercicio1.dominio;
using System.Globalization;


namespace Exercicio1.Dominio
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDeDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDeDesconto, Pedido pedido, Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDeDesconto = porcentagemDeDesconto;
            this.pedido = pedido;
            this.produto = produto;
        }

        public double subTotal()
        {
            double desconto = produto.preco * porcentagemDeDesconto / 100.00;
            return (produto.preco - desconto) * quantidade;
        }

        public override string ToString()
        {
            return $"{produto.descricao}, " +
                $"Preço: R${produto.preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade: {quantidade}, " +
                $"Desconto: {porcentagemDeDesconto}%, " +
                $"Subtotal: R${subTotal().ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
}
