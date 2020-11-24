// using System.Collections.Generic;

// namespace backend.Utils

// {
//     public class EstoqueConversor
//     {
//         public Models.TbEstoque ParaTabela(Models.Request.EstoqueRequest request)
//         {
//             Models.TbEstoque ln = new Models.TbEstoque();
//             ln.DsLocal = request.Local;
//             ln.DsQtd = request.Qtd;
//             ln.IdProduto = request.IdProduto;
//             ln.VlVenda = request.ValorVenda;
//             //ln.DtInclusao = DateTime.Now;

//             return ln;
//         }

//         public Models.Response.EstoqueResponse2 ParaResponse (Models.TbEstoque ln)
//         {
//             Models.Response.EstoqueResponse2 resp = new Models.Response.EstoqueResponse2();

//             resp.IdEstoque = ln.IdEstoque;
//             resp.IdProduto = ln.IdProduto;
//             resp.Local = ln.DsLocal;
//             resp.Qtd = ln.DsQtd.ToString();
//             resp.ValorVenda = ln.VlVenda;

//             return resp;
//         }

//         public List<Models.Response.EstoqueResponse2> ParaResponse (List<Models.TbEstoque> lns)
//         {
//             List<Models.Response.EstoqueResponse2> resp = new List<Models.Response.EstoqueResponse2>();
            
//             foreach (Models.TbEstoque item in lns)
//             {
//                 resp.Add(
//                 this.ParaResponse(item));
//             }

//             return resp;
//         }

        
//     }
// }