using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace backend.Controllers {

    [ApiController]
    [Route ("[controller]")]
    public class OrdemAbertaController : ControllerBase {

        Business.TbOrdemServicoBusiness buss = new Business.TbOrdemServicoBusiness ();
        Utils.TdOrdemServicoConversor util = new Utils.TdOrdemServicoConversor ();

        [HttpGet]

        public ActionResult<List<Models.Qtdaberta   >> Listar () {
            try {

                Models.opeContext ctx = new Models.opeContext();
                List<Models.Qtdaberta> lns = ctx.Qtdaberta.ToList();
                return lns;

            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (500, ex.Message)
                );
            }
        }


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

    }
}
