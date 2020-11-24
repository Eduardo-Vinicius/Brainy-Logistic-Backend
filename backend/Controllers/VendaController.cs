using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaController :ControllerBase
    {

        Business.VendaBusiness buss = new Business.VendaBusiness();
        Utils.VendaConversor util = new Utils.VendaConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.VendaResponse> Inserir (Models.Request.VendaRequest request)
        {
            try
            {
                Models.TbVenda ln = util.ParaTabela(request);
                buss.Salvar(ln);

                Models.Response.VendaResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.VendaResponse> Deletar (int id)
        {
            try
            {
                Models.TbVenda ln = buss.Deletar(id);
                
                Models.Response.VendaResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.VendaResponse> Alterar (int id, Models.Request.VendaRequest request)
        {
            try
            {
                Models.TbVenda ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.VendaResponse resp = util.ParaResponse(ln);
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
        public List<Models.TbVenda> Listar()
        {
            Models.opeContext ctx = new Models.opeContext();

            List<Models.TbVenda> clientes = ctx.TbVenda.ToList();
            
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
