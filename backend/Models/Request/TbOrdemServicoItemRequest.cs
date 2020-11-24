namespace backend.Models.Request
{
    public class TbOrdemServicoItemRequest
    {
        public int id_ordem_servico {get; set;}

        public int id_produto {get; set;}

        public int ds_qtd {get; set;}
    }
}