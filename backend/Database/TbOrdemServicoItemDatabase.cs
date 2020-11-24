using System.Collections.Generic;
using System.Linq;

namespace backend.Database {
    public class TbOrdemServicoItemDatabase {
        Models.opeContext db = new Models.opeContext ();

        public Models.TbOrdemServicoItem Salvar (Models.TbOrdemServicoItem os) {
            db.Add (os);
            db.SaveChanges ();

            return os;
        }

        public List<Models.TbOrdemServicoItem> Listar () {
            List<Models.TbOrdemServicoItem> lista = db.TbOrdemServicoItem.ToList ();

            return lista;
        }

        public Models.TbOrdemServicoItem Deletar (int id) { 
            Models.TbOrdemServicoItem os = db.TbOrdemServicoItem.FirstOrDefault (x => x.IdOrdemServico == id);

            if(os != null) {
                db.TbOrdemServicoItem.Remove (os);
                db.SaveChanges ();
            }
            return os;
        }

        public Models.TbOrdemServicoItem Alterar (int id, Models.TbOrdemServicoItem novo) {
            Models.TbOrdemServicoItem prod = db.TbOrdemServicoItem.FirstOrDefault (x => x.IdOrdemServicoItem == id);

            if (prod != null) {
                prod.IdOrdemServico = novo.IdOrdemServico;
                prod.IdProduto = novo.IdProduto;
                prod.DsQtd = novo.DsQtd;

                db.SaveChanges ();
            }

            return prod;
        }
    }

}