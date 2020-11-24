using System.Collections.Generic;

namespace backend.Business
{
    public class TbOrdemServicoItemBusiness
    {
        Database.TbOrdemServicoItemDatabase db = new Database.TbOrdemServicoItemDatabase ();

        public Models.TbOrdemServicoItem Salvar (Models.TbOrdemServicoItem save) {
            if (save.DsQtd <= 0)
                throw new System.Exception ("Valor incorreto");

            return db.Salvar (save);
        }

        public List<Models.TbOrdemServicoItem> Listar () {
            return db.Listar ();
        }

        public Models.TbOrdemServicoItem Deletar (int id) {
            return db.Deletar (id);
        }

        public Models.TbOrdemServicoItem Alterar (int id, Models.TbOrdemServicoItem novo) {
            if (novo.DsQtd <= 0)
            throw new System.Exception ("Valor obrigatório");

            return db.Alterar (id, novo);
        }
    }
}