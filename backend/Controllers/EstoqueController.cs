// using System.Collections.Generic;
// using System;
// using System.Collections;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;




// namespace backend.Controllers {

//     [ApiController]
//     [Route ("[controller]")]
//     public class EstoqueController : ControllerBase {


//         Business.EstoqueBusiness buss = new Business.EstoqueBusiness();
//         Utils.EstoqueConversor util = new Utils.EstoqueConversor();
        

//         [HttpPost]
//         public ActionResult<Models.Response.EstoqueResponse2> Inserir (Models.Request.EstoqueRequest request)
//         {
//             try
//             {
//                 Models.TbEstoque ln = util.ParaTabela(request);
//                 buss.Salvar(ln);

//                 Models.Response.EstoqueResponse2 resp = util.ParaResponse(ln);
//                 return resp;
//             }
//             catch (System.Exception ex)
//             {
                
//                 return BadRequest(
//                     new Models.Response.ErroResponse(404, ex.Message)
//                 );
//             }
//         }


//         [HttpGet]

//         public List<Models.Estoqueview> Listar() 
//         {
//             Models.opeContext ctx = new Models.opeContext();
//             // .Where(P => P.DsStatus == "Fechado")
//             List<Models.Estoqueview> estoque = ctx.Estoqueview.ToList();

            
//             // List<Models.TbOrdemServico> servicos = ctx.TbOrdemServico
//             //         .Include(x => x.IdClienteNavigation)
//             //         .Include(y => y.IdFuncionarioNavigation)
//             //     .ToList();
            
//             // List<Models.Response.OrdemServicoResponse> response = 
//             //     servicos.Select(x => new Models.Response.OrdemServicoResponse {
//             //         Id = x.IdOrdemServico,
//             //         Funcionario = x.IdFuncionarioNavigation.NmFuncionario,
//             //         Cliente = x.IdClienteNavigation.NmCliente,
//             //         Email = x.IdClienteNavigation.DsEmail,
//             //         Bicicleta = x.IdClienteNavigation.DsBicicleta,
//             //         Valor = Convert.ToString(x.DsValor),
//             //         DtOrdemServico = Convert.ToString(x.DtOrdemServico),
//             //         Status = x.DsStatus


//             //     }).ToList();

//             return estoque;
//         }

//         [HttpPut("{id}")]
//         public ActionResult<Models.Response.EstoqueResponse2> Alterar (int id, Models.Request.EstoqueRequest request)
//         {
//             try
//             {
//                 Models.TbEstoque ln = util.ParaTabela(request);
//                 buss.Alterar(id, ln);

//                 Models.Response.EstoqueResponse2 resp = util.ParaResponse(ln);
//                 return resp;
//             }
//             catch (System.Exception ex)
//             {
                
//                 return BadRequest(
//                     new Models.Response.ErroResponse(404, ex.Message)
//                 );
//             }
//         }


//     }
// }
