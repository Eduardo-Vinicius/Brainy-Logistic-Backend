namespace backend.Models.Response
{
    public class TbOrdemServicoItemResponse
    {
        public int id_ordem_servico_item {get; set;}

        public int id_ordem_servico {get; set;}

        public int id_produto {get; set;}

        public int ds_qtd {get; set;}
    }
}