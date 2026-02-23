using System;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste Incremento 1 
            Console.WriteLine("INCREMENTO 1: CARRINHO");
            Carrinho meuCarrinho = new Carrinho();
            meuCarrinho.AdicionarProduto(new Produto("Monitor", 1200.00));
            meuCarrinho.AdicionarProduto(new Produto("Mouse", 80.00));

            double totalCarrinho = meuCarrinho.CalcularTotal();
            Console.WriteLine($"Total no Carrinho: R$ {totalCarrinho:F2}");

            // Teste incremento 2
            Console.WriteLine("\nINCREMENTO 2: PAGAMENTO");
            Pagamento pgto = new Pagamento();
            pgto.TipoPagamento = "Cartão de Crédito";

            // Integração com o total do carrinho
            pgto.ProcessarPagamento(totalCarrinho);

            Console.ReadKey();
        }
    }
}