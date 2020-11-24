namespace backend.Models.Request
{
    public class EstoqueRequest
    {
        public string Local {get; set;}
        public int Qtd {get; set;}
        public int IdProduto {get; set;}
        public decimal ValorVenda {get;set;}
       
    }
}