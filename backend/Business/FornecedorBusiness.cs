using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Business
{
    public class FornecedorBusiness
    {
    Database.FornecedorDatabase db = new Database.FornecedorDatabase();

    public Models.TbFornecedor Salvar (Models.TbFornecedor ln)
    {
        if (ln.NmFornecedor == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (ln.DsCnpj == string.Empty)
            throw new Exception("CNPJ é obrigatório!!");
        
        return db.Salvar(ln);

    }

    public List<Models.TbFornecedor> Listar()
    {
        return db.Listar();
    }

    public Models.TbFornecedor Deletar(int id)
    {
        return db.Deletar(id);
    }

    public Models.TbFornecedor Alterar(int id, Models.TbFornecedor novo)
    {
        if (novo.NmFornecedor == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (novo.DsRazaosocial == string.Empty)
            throw new Exception("Razão social é obrigatório");
        if (novo.DsCnpj == string.Empty)
            throw new Exception("CNPJ é obrigatório!!");
        
        return db.Alterar(id, novo);
    }




    }
}