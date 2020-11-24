using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CompraController :ControllerBase
    {

        Business.CompraBusiness buss = new Business.CompraBusiness();
        Utils.CompraConversor util = new Utils.CompraConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.CompraResponse> Inserir (Models.Request.CompraRequest request)
        {
            try
            {
                Models.TbCompra ln = util.ParaTabela(request);
                buss.Salvar(ln);

                Models.Response.CompraResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.CompraResponse> Deletar (int id)
        {
            try
            {
                Models.TbCompra ln = buss.Deletar(id);
                
                Models.Response.CompraResponse resp = util.ParaResponse(ln);
                return resp;
            }
            catch (System.Exception ex)
            {
                
                return BadRequest(
                    new Models.Response.ErroResponse(404, ex.Message)
                );
            }
        }


        // [HttpPut("{id}")]
        // public ActionResult<Models.Response.ClienteResponse> Alterar (int id, Models.Request.ClienteRequest request)
        // {
        //     try
        //     {
        //         Models.TbCliente ln = util.ParaTabela(request);
        //         buss.Alterar(id, ln);

        //         Models.Response.ClienteResponse resp = util.ParaResponse(ln);
        //         return resp;
        //     }
        //     catch (System.Exception ex)
        //     {
                
        //         return BadRequest(
        //             new Models.Response.ErroResponse(404, ex.Message)
        //         );
        //     }
        // }

        [HttpGet]
        public List<Models.TbCompra> Listar()
        {
            Models.opeContext ctx = new Models.opeContext();

            List<Models.TbCompra> clientes = ctx.TbCompra.ToList();
            
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
