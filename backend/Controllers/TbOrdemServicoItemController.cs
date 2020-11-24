using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers {

    [ApiController]
    [Route ("[controller]")]
    public class TbOrdemServicoItemController : ControllerBase {

        Business.TbOrdemServicoItemBusiness buss = new Business.TbOrdemServicoItemBusiness ();
        Utils.TbOrdemServicoItemConversor util = new Utils.TbOrdemServicoItemConversor ();

        [HttpPost]
        public ActionResult<Models.Response.TbOrdemServicoItemResponse> Inserir (Models.Request.TbOrdemServicoItemRequest request) {
            try {
                Models.TbOrdemServicoItem func = util.ParaTabela (request);
                buss.Salvar (func);

                Models.Response.TbOrdemServicoItemResponse resp = util.ParaResponse (func);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpDelete ("{id}")]
        public ActionResult<Models.Response.TbOrdemServicoItemResponse> Deletar (int id) {
            try {
                Models.TbOrdemServicoItem ln = buss.Deletar (id);

                Models.Response.TbOrdemServicoItemResponse resp = util.ParaResponse (ln);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpPut ("{id}")]
        public ActionResult<Models.Response.TbOrdemServicoItemResponse> Alterar (int id, Models.Request.TbOrdemServicoItemRequest request) {
            try {
                Models.TbOrdemServicoItem ln = util.ParaTabela (request);
                buss.Alterar (id, ln);

                Models.Response.TbOrdemServicoItemResponse resp = util.ParaResponse (ln);
                return resp;
            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (404, ex.Message)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.TbOrdemServicoItemResponse>> Listar () {
            try {
                List<Models.TbOrdemServicoItem> lns = buss.Listar ();
                if (lns.Count == 0)
                    return NotFound ();

                List<Models.Response.TbOrdemServicoItemResponse> resp = util.ParaResponse (lns);
                return resp;

            } catch (System.Exception ex) {

                return BadRequest (
                    new Models.Response.ErroResponse (500, ex.Message)
                );
            }
        }

    }
}