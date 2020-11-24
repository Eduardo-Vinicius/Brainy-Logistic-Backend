using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class VendaItemBusiness
    {
    Database.VendaItemDatabase db = new Database.VendaItemDatabase();

    public Models.TbVendaItem Salvar (Models.TbVendaItem ln)
    {
        // if (ln.NmCliente == string.Empty)
        //     throw new Exception("Nome é obrigatório");
        // if (ln.DsCpf == string.Empty)
        //     throw new Exception("CPF é obrigatório!!");
        return db.Salvar(ln);
    }

    public List<Models.TbVendaItem> Listar()
    {
        return db.Listar();
    }

    public Models.TbVendaItem Deletar(int id)
    {
        return db.Deletar(id);
    }
    public Models.TbVendaItem Alterar(int id, Models.TbVendaItem novo)
    {

       return db.Alterar(id, novo);
    }



    }
}