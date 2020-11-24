using System;

namespace backend.Models.Request
{
    public class VendaItemRequest
    {

        public decimal ValorTotal { get; set; }
        public int Qtd { get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
    }
}