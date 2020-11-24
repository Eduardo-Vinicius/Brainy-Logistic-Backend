using System;
using System.Collections.Generic;

namespace backend.Business {
    public class TbOrdemServicoBusiness {
        Database.TbOrdemServicoDatabase db = new Database.TbOrdemServicoDatabase ();

        public Models.TbOrdemServico Salvar (Models.TbOrdemServico save) {
            if (save.DsValor <= 0)
                throw new Exception ("Valor incorreto");

            return db.Salvar(save);

        }
        public List<Models.TbOrdemServico> Listar () {
            return db.Listar();
        }
        public Models.TbOrdemServico Deletar (int id) {
            
            return db.Deletar(id);
        }
        public Models.TbOrdemServico Alterar (int id, Models.TbOrdemServico novo) {
            if (novo.DsValor <= 0)
                throw new Exception ("Valor obrigatório");

            return db.Alterar (id, novo);
        }
    }

}