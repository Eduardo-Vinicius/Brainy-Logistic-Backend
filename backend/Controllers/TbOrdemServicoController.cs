using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace backend.Controllers {

    [ApiController]
    [Route ("[controller]")]
    public class TbOrdemServicoController : ControllerBase {

        Business.TbOrdemServicoBusiness buss = new Business.TbOrdemServicoBusiness ();
        Utils.TdOrdemServicoConversor util = new Utils.TdOrdemServicoConversor ();

        [HttpPost]
        public ActionResult<Models.Response.TbOrdemServicoResponse> Inserir (Models.Request.TbOrdemServicoRequest request) {
            try {
                Models.TbOrdemServico func = util.ParaTabela (request);
                buss.Salvar (func);

                Models.Response.TbOrdemServicoResponse resp = util.ParaResponse (func);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Models.Response.TbOrdemServicoResponse> Deletar (int id) {
            try {
                Models.TbOrdemServico ln = buss.Deletar(id);

                Models.Response.TbOrdemServicoResponse resp = util.ParaResponse(ln);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpPut ("{id}")]
        public ActionResult<Models.Response.TbOrdemServicoResponse> Alterar (int id, Models.Request.TbOrdemServicoRequest request) {
            try {
                Models.TbOrdemServico ln = util.ParaTabela (request);
                buss.Alterar (id, ln);

                Models.Response.TbOrdemServicoResponse resp = util.ParaResponse (ln);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpGet]

//         public List<Models.Response.OrdemServicoResponse> Listar() 
//         {
//             Models.opeContext ctx = new Models.opeContext();
// // .Where(P => P.DsStatus == "Fechado")
//             List<Models.TbOrdemServico> servicos = ctx.TbOrdemServico
//                     .Include(x => x.IdClienteNavigation)
//                     .Include(y => y.IdFuncionarioNavigation)
//                 .ToList();
            
//             List<Models.Response.OrdemServicoResponse> response = 
//                 servicos.Select(x => new Models.Response.OrdemServicoResponse {
//                     Id = x.IdOrdemServico,
//                     Funcionario = x.IdFuncionarioNavigation.NmFuncionario,
//                     Cliente = x.IdClienteNavigation.NmCliente,
//                     Email = x.IdClienteNavigation.DsEmail,
//                     Bicicleta = x.IdClienteNavigation.DsBicicleta,
//                     Valor = Convert.ToString(x.DsValor),
//                     DtOrdemServico = Convert.ToString(x.DtOrdemServico),
//                     Status = x.DsStatus


//                 }).ToList();

//             return response;
//         }
        public ActionResult<List<Models.Response.TbOrdemServicoResponse>> Listar () {
            try {
                List<Models.TbOrdemServico> lns = buss.Listar ();
                if (lns.Count == 0)
                    return NotFound ();

                List<Models.Response.TbOrdemServicoResponse> resp = util.ParaResponse (lns);
                return resp;

            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (500, ex.Message)
                );
            }
        }

    }
}
