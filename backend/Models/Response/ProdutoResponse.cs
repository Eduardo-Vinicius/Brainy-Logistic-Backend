using System;


namespace backend.Models.Response
{
    public class ProdutoResponse
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Marca {get; set;}
        public DateTime DataCompra {get; set;}
        public decimal ValorVenda {get; set;}
        public int Qtd {get; set;}

    }
}