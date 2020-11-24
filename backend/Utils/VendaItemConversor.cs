using System.Collections.Generic;

namespace backend.Utils

{
    public class VendaItemConversor
    {
        public Models.TbVendaItem ParaTabela(Models.Request.VendaItemRequest request)
        {
            Models.TbVendaItem ln = new Models.TbVendaItem();
            ln.DsQtd = request.Qtd;
            ln.VlTotal = request.ValorTotal;
            ln.IdVenda = request.IdVenda;
            ln.IdProduto = request.IdProduto;
            return ln;
        }

        public Models.Response.VendaItemResponse ParaResponse (Models.TbVendaItem ln)
        {
            Models.Response.VendaItemResponse resp = new Models.Response.VendaItemResponse();
            resp.Id = ln.IdVendaItem;
            resp.Qtd = ln.DsQtd;
            resp.ValorTotal = ln.VlTotal;
            resp.IdProduto = ln.IdProduto;
            resp.IdVenda = ln.IdVenda;
            return resp;
        }

        public List<Models.Response.VendaItemResponse> ParaResponse (List<Models.TbVendaItem> lns)
        {
            List<Models.Response.VendaItemResponse> resp = new List<Models.Response.VendaItemResponse>();
            
            foreach (Models.TbVendaItem item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}