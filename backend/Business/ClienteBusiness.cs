using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class ClienteBusiness
    {
    Database.ClienteDatabase db = new Database.ClienteDatabase();

    public Models.TbCliente Salvar (Models.TbCliente ln)
    {
        if (ln.NmCliente == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (ln.DsCpf == string.Empty)
            throw new Exception("CPF é obrigatório!!");
        
        return db.Salvar(ln);

    }

    public List<Models.TbCliente> Listar()
    {
        return db.Listar();
    }

    public Models.TbCliente Deletar(int id)
    {
        return db.Deletar(id);
    }
    public Models.TbCliente Alterar(int id, Models.TbCliente novo)
    {
        if (novo.NmCliente == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (novo.DsCpf == string.Empty)
            throw new Exception("CPF é obrigatório!!");

       return db.Alterar(id, novo);
    }



    }
}