using System.Collections.Generic;

namespace backend.Utils

{
    public class VendaConversor
    {
        public Models.TbVenda ParaTabela(Models.Request.VendaRequest request)
        {
            Models.TbVenda ln = new Models.TbVenda();
            ln.DtVenda = request.DataVenda;
            ln.DsValor = request.Valor;
            ln.IdFuncionario = request.IdFuncionario;
            ln.IdCliente = request.IdCliente;
            return ln;
        }

        public Models.Response.VendaResponse ParaResponse (Models.TbVenda ln)
        {
            Models.Response.VendaResponse resp = new Models.Response.VendaResponse();
            resp.Id = ln.IdVenda;
            resp.DataVenda = ln.DtVenda;
            resp.Valor = ln.DsValor;
            resp.IdFuncionario = ln.IdFuncionario;
            resp.IdCliente = ln.IdCliente;
            

            return resp;
        }

        public List<Models.Response.VendaResponse> ParaResponse (List<Models.TbVenda> lns)
        {
            List<Models.Response.VendaResponse> resp = new List<Models.Response.VendaResponse>();
            
            foreach (Models.TbVenda item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}