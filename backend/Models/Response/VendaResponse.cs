using System;

namespace backend.Models.Response
{
    public class VendaResponse
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataVenda { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
    }
}