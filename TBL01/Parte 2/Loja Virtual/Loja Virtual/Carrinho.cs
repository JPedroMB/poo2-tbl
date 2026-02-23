using System;
using System.Collections.Generic;

namespace LojaVirtual
{
    public class Carrinho
    {
        public List<Produto> Itens { get; set; } = new List<Produto>();

        // Método para adicionar produtos (Requisito Incremento 1)
        public void AdicionarProduto(Produto p)
        {
            Itens.Add(p);
            Console.WriteLine($"Produto '{p.Nome}' adicionado.");
        }

        // Método para calcular total (Requisito Incremento 1)
        public double CalcularTotal()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.Preco;
            }
            return total;
        }
    }
}