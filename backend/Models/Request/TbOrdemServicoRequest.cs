using System;

namespace backend.Models.Request
{
    public class TbOrdemServicoRequest
    {
        public decimal Valor {get; set;}

        public DateTime DtOrdemServico {get; set;}

        public int IdFuncionario {get; set;}
        public int IdCliente {get; set;}
        public string Status {get;set;}

        public decimal ValorManutencao {get;set;}
    }
}