using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FornecedorController :ControllerBase
    {
        Business.FornecedorBusiness buss = new Business.FornecedorBusiness();
        Utils.FornecedorConversor util = new Utils.FornecedorConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.FornecedorResponse> Inserir (Models.Request.FornecedorRequest request)
        {
            try
            {
                Models.TbFornecedor func = util.ParaTabela(request);
                buss.Salvar(func);

                Models.Response.FornecedorResponse resp = util.ParaResponse(func);
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
        public ActionResult<Models.Response.FornecedorResponse> Deletar (int id)
        {
            try
            {
                Models.TbFornecedor ln = buss.Deletar(id);
                
                Models.Response.FornecedorResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.FornecedorResponse> Alterar (int id, Models.Request.FornecedorRequest request)
        {
            try
            {
                Models.TbFornecedor ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.FornecedorResponse resp = util.ParaResponse(ln);
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
        public ActionResult<List<Models.Response.FornecedorResponse>> Listar()
        {
            try
            {
                List<Models.TbFornecedor> lns = buss.Listar();
                if (lns.Count == 0)
                    return NotFound();

                List<Models.Response.FornecedorResponse> resp = util.ParaResponse(lns);
                return resp;

                
    
            }
            catch (System.Exception ex)
            {

                return BadRequest(
                    new Models.Response.ErroResponse(500, ex.Message)
                );
            }
        }




    }
}
