using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;



namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController :ControllerBase
    {

        Business.FuncionarioBusiness buss = new Business.FuncionarioBusiness();
        Utils.FuncionarioConversor util = new Utils.FuncionarioConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.FuncionarioResponse> Inserir (Models.Request.FuncionarioRequest request)
        {
            try
            {
                Models.TbFuncionario func = util.ParaTabela(request);
                buss.Salvar(func);

                Models.Response.FuncionarioResponse resp = util.ParaResponse(func);
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
        public ActionResult<Models.Response.FuncionarioResponse> Deletar (int id)
        {
            try
            {
                Models.TbFuncionario ln = buss.Deletar(id);
                
                Models.Response.FuncionarioResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.FuncionarioResponse> Alterar (int id, Models.Request.FuncionarioRequest request)
        {
            try
            {
                Models.TbFuncionario ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.FuncionarioResponse resp = util.ParaResponse(ln);
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
        public ActionResult<List<Models.Response.FuncionarioResponse>> Listar()
        {
            try
            {
                List<Models.TbFuncionario> lns = buss.Listar();
                if (lns.Count == 0)
                    return NotFound();

                List<Models.Response.FuncionarioResponse> resp = util.ParaResponse(lns);
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
