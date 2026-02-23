using System;

namespace SistemaPedidoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. cliente criado
            Cliente cliente1 = new Cliente("João Silva", "123.456.789-00");

            // 2. 2 produtos
            Produto prod1 = new Produto("Teclado Gamer", 299.90);
            Produto prod2 = new Produto("Mouse Wireless", 150.00);
            

            // 3. criar um pedido e associar ao cliente
            Pedido novoPedido = new Pedido(cliente1);

            // 4. associar produtos ao pedido
            novoPedido.Produtos.Add(prod1);
            novoPedido.Produtos.Add(prod2);
           

            // 5. exibir o resumo validando o total
            novoPedido.ExibirResumo();


            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}