using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class CompraBusiness
    {
    Database.CompraDatabase db = new Database.CompraDatabase();

    public Models.TbCompra Salvar (Models.TbCompra ln)
    {
        // if (ln.NmCliente == string.Empty)
        //     throw new Exception("Nome é obrigatório");
        // if (ln.DsCpf == string.Empty)
        //     throw new Exception("CPF é obrigatório!!");
        
        return db.Salvar(ln);

    }

    public List<Models.TbCompra> Listar()
    {
        return db.Listar();
    }

    public Models.TbCompra Deletar(int id)
    {
        return db.Deletar(id);
    }
    // public Models.TbCompra Alterar(int id, Models.TbCompra novo)
    // {

    //    return db.Alterar(id, novo);
    // }



    }
}