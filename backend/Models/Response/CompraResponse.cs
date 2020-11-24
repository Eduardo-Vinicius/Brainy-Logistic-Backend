using System;

namespace backend.Models.Response

{
    public class CompraResponse
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int Qtd { get; set; }
        public string Produto { get; set; }
        public string Marca { get; set; }
        public int IdFornecedor { get; set; }
        public int IdFuncionario { get; set; }
    }
}