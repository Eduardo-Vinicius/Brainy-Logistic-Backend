using System;

namespace backend.Models.Response
{
    public class TbOrdemServicoResponse
    {
        public int Id {get; set;}
        public decimal Valor {get; set;}
        public DateTime DtOrdemServico {get; set;}
        public int IdFuncionario {get; set;}
        public int IdCliente {get; set;}

        public string Status {get; set;}
        public decimal? ValorManutencao { get; set; }
    }
}