using System.Collections.Generic;

namespace backend.Utils

{
    public class ProdutoConversor
    {
        public Models.TbProduto ParaTabela(Models.Request.ProdutoRequest request)
        {
            Models.TbProduto func = new Models.TbProduto();
            func.NmProduto = request.Nome;
            func.DsMarca = request.Marca;
            func.DtCompra = request.DataCompra;
            func.VlVenda = request.ValorVenda;
            func.DsQtd = request.Qtd;

            return func;
        }

        public Models.Response.ProdutoResponse ParaResponse (Models.TbProduto ln)
        {
            Models.Response.ProdutoResponse resp = new Models.Response.ProdutoResponse();
            resp.Id = ln.IdProduto;
            resp.Nome = ln.NmProduto;
            resp.Marca = ln.DsMarca;
            resp.DataCompra = ln.DtCompra;
            resp.ValorVenda = ln.VlVenda;
            resp.Qtd = ln.DsQtd;
          

            return resp;
        }

        public List<Models.Response.ProdutoResponse> ParaResponse (List<Models.TbProduto> lns)
        {
            List<Models.Response.ProdutoResponse> resp = new List<Models.Response.ProdutoResponse>();
            
            foreach (Models.TbProduto item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}