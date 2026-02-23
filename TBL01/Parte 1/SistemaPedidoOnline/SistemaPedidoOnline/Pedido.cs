using System;
using System.Collections.Generic;

namespace SistemaPedidoOnline
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
        }

        // Método para cálculo do total (R4)
        public double CalcularTotal()
        {
            double total = 0;
            foreach (var p in Produtos)
            {
                total += p.Preco;
            }
            return total;
        }

        // Método para exibição do resumo (R4)
        public void ExibirResumo()
        {
            
            Console.WriteLine("           RESUMO DO PEDIDO             ");
            
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"CPF: {Cliente.CPF}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Produtos Selecionados:");

            foreach (var p in Produtos)
            {
                Console.WriteLine($"- {p.Nome.PadRight(20)} R$ {p.Preco:F2}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"TOTAL DO PEDIDO:      R$ {CalcularTotal():F2}");
           
        }
    }
}