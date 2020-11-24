using System.Collections.Generic;
using System.Linq;

namespace backend.Database {
    public class TbOrdemServicoDatabase {
        Models.opeContext db = new Models.opeContext ();

        public Models.TbOrdemServico Salvar (Models.TbOrdemServico os) {
            db.Add (os);
            db.SaveChanges ();

            return os;
        }

        public List<Models.TbOrdemServico> Listar () {
            List<Models.TbOrdemServico> lista = db.TbOrdemServico.ToList();

            return lista;
        }
        public Models.TbOrdemServico Deletar (int id) 
        {
            Models.TbOrdemServico os = db.TbOrdemServico.FirstOrDefault(x => x.IdOrdemServico == id);

            if (os != null) {
                db.TbOrdemServico.Remove(os);
                db.SaveChanges ();
            }
            return os;
        }
        public Models.TbOrdemServico Alterar (int id, Models.TbOrdemServico novo) {
            Models.TbOrdemServico prod = db.TbOrdemServico.FirstOrDefault (x => x.IdOrdemServico == id);

            if (prod != null) {

                prod.DsValor = novo.DsValor;
                prod.DtOrdemServico = novo.DtOrdemServico;
                prod.IdFuncionario = novo.IdFuncionario;
                prod.IdCliente = novo.IdCliente;
                prod.DsStatus = novo.DsStatus;

                db.SaveChanges ();

            }

            return prod;
        }
    }
}