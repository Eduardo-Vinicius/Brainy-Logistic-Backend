using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VendaItemController :ControllerBase
    {

        Business.VendaItemBusiness buss = new Business.VendaItemBusiness();
        Utils.VendaItemConversor util = new Utils.VendaItemConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.VendaItemResponse> Inserir (Models.Request.VendaItemRequest request)
        {
            try
            {
                Models.TbVendaItem ln = util.ParaTabela(request);
                buss.Salvar(ln);

                Models.Response.VendaItemResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.VendaItemResponse> Deletar (int id)
        {
            try
            {
                Models.TbVendaItem ln = buss.Deletar(id);
                
                Models.Response.VendaItemResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.VendaItemResponse> Alterar (int id, Models.Request.VendaItemRequest request)
        {
            try
            {
                Models.TbVendaItem ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.VendaItemResponse resp = util.ParaResponse(ln);
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
        public List<Models.TbVendaItem> Listar()
        {
            Models.opeContext ctx = new Models.opeContext();

            List<Models.TbVendaItem> venda_item = ctx.TbVendaItem.ToList();
            
            return venda_item;
        }
    }
}
