using System.Collections.Generic;

namespace backend.Utils

{
    public class CompraConversor
    {
        public Models.TbCompra ParaTabela(Models.Request.CompraRequest request)
        {
            Models.TbCompra ln = new Models.TbCompra();
            ln.DtCompra = request.DataCompra;
            ln.IdFornecedor = request.IdFornecedor;
            ln.IdFuncionario = request.IdFuncionario;
            ln.NmProduto = request.Produto;
            ln.VlVenda = request.ValorVenda;
            ln.VlCompra = request.ValorCompra;
            ln.DsMarca = request.Marca;
            ln.DsQtd = request.Qtd;
            return ln;
        }

        public Models.Response.CompraResponse ParaResponse (Models.TbCompra ln)
        {
            Models.Response.CompraResponse resp = new Models.Response.CompraResponse();
            resp.Id = ln.IdCompra;
            resp.Produto = ln.NmProduto;
            resp.Marca = ln.DsMarca;
            resp.Qtd = ln.DsQtd;
            resp.ValorCompra = ln.VlCompra;
            resp.ValorVenda = ln.VlVenda;
            resp.IdFornecedor = ln.IdFornecedor;
            resp.IdFuncionario = ln.IdFuncionario;
            return resp;
        }

        public List<Models.Response.CompraResponse> ParaResponse (List<Models.TbCompra> lns)
        {
            List<Models.Response.CompraResponse> resp = new List<Models.Response.CompraResponse>();
            
            foreach (Models.TbCompra item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}