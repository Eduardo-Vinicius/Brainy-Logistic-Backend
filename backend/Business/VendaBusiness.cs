using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class VendaBusiness
    {
    Database.VendaDatabase db = new Database.VendaDatabase();

    public Models.TbVenda Salvar (Models.TbVenda ln)
    {
        // if (ln.NmCliente == string.Empty)
        //     throw new Exception("Nome é obrigatório");
        // if (ln.DsCpf == string.Empty)
        //     throw new Exception("CPF é obrigatório!!");
        return db.Salvar(ln);
    }

    public List<Models.TbVenda> Listar()
    {
        return db.Listar();
    }

    public Models.TbVenda Deletar(int id)
    {
        return db.Deletar(id);
    }
    public Models.TbVenda Alterar(int id, Models.TbVenda novo)
    {

       return db.Alterar(id, novo);
    }



    }
}