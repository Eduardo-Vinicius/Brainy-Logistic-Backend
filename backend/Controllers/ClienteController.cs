using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController :ControllerBase
    {

        Business.ClienteBusiness buss = new Business.ClienteBusiness();
        Utils.ClienteConversor util = new Utils.ClienteConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.ClienteResponse> Inserir (Models.Request.ClienteRequest request)
        {
            try
            {
                Models.TbCliente ln = util.ParaTabela(request);
                buss.Salvar(ln);

                Models.Response.ClienteResponse resp = util.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Models.Response.ClienteResponse> Deletar (int id)
        {
            try
            {
                Models.TbCliente ln = buss.Deletar(id);
                
                Models.Response.ClienteResponse resp = util.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Models.Response.ClienteResponse> Alterar (int id, Models.Request.ClienteRequest request)
        {
            try
            {
                Models.TbCliente ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.ClienteResponse resp = util.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }

        [HttpGet]
        public List<Models.TbCliente> Listar()
        {
            Models.opeContext ctx = new Models.opeContext();

            List<Models.TbCliente> clientes = ctx.TbCliente.ToList();
            
            return clientes;
        }

        // public ActionResult<List<Models.Response.ClienteResponse>> Listar()
        // {
        //     try
        //     {
        //         List<Models.TbCliente> lns = buss.Listar();
        //         if (lns.Count == 0)
        //             return NotFound();

        //         List<Models.Response.ClienteResponse> resp = util.ParaResponse(lns);
        //         return resp;

                
    
        //     }
        //     catch (System.Exception ex)
        //     {

        //         return BadRequest(
        //             new Models.Response.ErroResponse(500, ex.Message)
        //         );
        //     }
        // }




    }
}
