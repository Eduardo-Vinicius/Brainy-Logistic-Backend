using System.Collections.Generic;

namespace backend.Utils
{
    public class TbOrdemServicoItemConversor
    {   
        public Models.TbOrdemServicoItem ParaTabela (Models.Request.TbOrdemServicoItemRequest request) { 
            Models.TbOrdemServicoItem func = new Models.TbOrdemServicoItem ();
            func.DsQtd = request.ds_qtd;
            func.IdOrdemServico = request.id_ordem_servico;
            func.IdProduto = request.id_produto;

            return func;
        }
        
        public Models.Response.TbOrdemServicoItemResponse ParaResponse (Models.TbOrdemServicoItem ln)
        {
            Models.Response.TbOrdemServicoItemResponse resp = new Models.Response.TbOrdemServicoItemResponse();
            resp.id_ordem_servico_item = ln.IdOrdemServicoItem;
            resp.ds_qtd = ln.DsQtd;
            resp.id_ordem_servico = ln.IdOrdemServico;
            resp.id_produto = ln.IdProduto;

            return resp;
        }

        public List<Models.Response.TbOrdemServicoItemResponse> ParaResponse (List<Models.TbOrdemServicoItem> lns)
        {
            List<Models.Response.TbOrdemServicoItemResponse> resp = new List<Models.Response.TbOrdemServicoItemResponse>();

            foreach (Models.TbOrdemServicoItem item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }

            return resp;
        }
    }
}