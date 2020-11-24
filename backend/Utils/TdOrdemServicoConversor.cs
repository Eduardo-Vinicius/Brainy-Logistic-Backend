using System.Collections.Generic;

namespace backend.Utils {
    public class TdOrdemServicoConversor {
        public Models.TbOrdemServico ParaTabela (Models.Request.TbOrdemServicoRequest request) {
            Models.TbOrdemServico func = new Models.TbOrdemServico ();
            func.DsValor = request.Valor;
            func.DtOrdemServico = request.DtOrdemServico;
            func.IdCliente = request.IdCliente;
            func.IdFuncionario = request.IdFuncionario;
            func.DsStatus = request.Status;
            func.DsValorManutencao = request.ValorManutencao;
            return func;
        }
        
        public Models.Response.TbOrdemServicoResponse ParaResponse (Models.TbOrdemServico ln)
        {
            Models.Response.TbOrdemServicoResponse resp = new Models.Response.TbOrdemServicoResponse();
            resp.Id = ln.IdOrdemServico;
            resp.Valor = ln.DsValor;
            resp.DtOrdemServico = ln.DtOrdemServico;
            resp.IdCliente = ln.IdCliente;
            resp.IdFuncionario = ln.IdFuncionario;
            resp.Status = ln.DsStatus;
            resp.ValorManutencao = ln.DsValorManutencao;

            return resp;
        }

        public List<Models.Response.TbOrdemServicoResponse> ParaResponse (List<Models.TbOrdemServico> lns)
        {
            List<Models.Response.TbOrdemServicoResponse> resp = new List<Models.Response.TbOrdemServicoResponse>();
            
            foreach (Models.TbOrdemServico item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }
        
    }   
}