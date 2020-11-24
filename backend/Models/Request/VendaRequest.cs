using System;

namespace backend.Models.Request
{
    public class VendaRequest
    {

        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
    }
}