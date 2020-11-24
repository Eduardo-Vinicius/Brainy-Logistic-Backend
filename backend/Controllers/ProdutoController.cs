using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProdutoController :ControllerBase
    {
        Business.ProdutoBusiness buss = new Business.ProdutoBusiness();
        Utils.ProdutoConversor util = new Utils.ProdutoConversor();
        
        [HttpPost]
        public ActionResult<Models.Response.ProdutoResponse> Inserir (Models.Request.ProdutoRequest request)
        {
            try
            {
                Models.TbProduto func = util.ParaTabela(request);
                buss.Salvar(func);

                Models.Response.ProdutoResponse resp = util.ParaResponse(func);
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
        public ActionResult<Models.Response.ProdutoResponse> Deletar (int id)
        {
            try
            {
                Models.TbProduto ln = buss.Deletar(id);
                
                Models.Response.ProdutoResponse resp = util.ParaResponse(ln);
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
        public ActionResult<Models.Response.ProdutoResponse> Alterar (int id, Models.Request.ProdutoRequest request)
        {
            try
            {
                Models.TbProduto ln = util.ParaTabela(request);
                buss.Alterar(id, ln);

                Models.Response.ProdutoResponse resp = util.ParaResponse(ln);
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
        public ActionResult<List<Models.Response.ProdutoResponse>> Listar()
        {
            try
            {
                List<Models.TbProduto> lns = buss.Listar();
                if (lns.Count == 0)
                    return NotFound();

                List<Models.Response.ProdutoResponse> resp = util.ParaResponse(lns);
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
