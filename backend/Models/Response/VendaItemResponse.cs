using System;

namespace backend.Models.Response
{
    public class VendaItemResponse
    {
        public int Id { get; set; }

        public decimal ValorTotal { get; set; }
        public int Qtd { get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
    }
}