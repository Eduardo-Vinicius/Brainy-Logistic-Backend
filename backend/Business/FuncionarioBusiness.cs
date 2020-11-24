using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class FuncionarioBusiness
    {
    Database.FuncionarioDatabase db = new Database.FuncionarioDatabase();

    public Models.TbFuncionario Salvar (Models.TbFuncionario ln)
    {
        if (ln.NmFuncionario == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (ln.DsCpf == string.Empty)
            throw new Exception("CPF é obrigatório!!");
        
        return db.Salvar(ln);

    }

    public List<Models.TbFuncionario> Listar()
    {
        return db.Listar();
    }

    public Models.TbFuncionario Deletar(int id)
    {
        return db.Deletar(id);
    }

    public Models.TbFuncionario Alterar(int id, Models.TbFuncionario novo)
    {
        if (novo.NmFuncionario == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (novo.DsCpf == string.Empty)
            throw new Exception("CPF é obrigatório!!");
        
        return db.Alterar(id, novo);
    }




    }
}