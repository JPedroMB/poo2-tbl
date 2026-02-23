using System;

namespace LojaVirtual
{
    public class Pagamento
    {
        public string TipoPagamento { get; set; }

        // Método para processar pagamento (Requisito Incremento 2)
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine("\n PROCESSAMENTO DE PAGAMENTO");
            Console.WriteLine($"Tipo: {TipoPagamento}");
            Console.WriteLine($"Valor Processado: R$ {valor:F2}");
            Console.WriteLine("Status: Sucesso");
            Console.WriteLine("----------------------------------");
        }
    }
}