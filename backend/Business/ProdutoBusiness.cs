using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class ProdutoBusiness
    {
    Database.ProdutoDatabase db = new Database.ProdutoDatabase();

    public Models.TbProduto Salvar (Models.TbProduto ln)
    {
        if (ln.NmProduto == string.Empty)
            throw new Exception("Nome do produto é obrigatório");
        if (ln.DsMarca == string.Empty)
            throw new Exception("Marca é obrigatório!!");
        
        return db.Salvar(ln);

    }

    public List<Models.TbProduto> Listar()
    {
        return db.Listar();
    }

    public Models.TbProduto Deletar(int id)
    {
        return db.Deletar(id);
    }

    public Models.TbProduto Alterar(int id, Models.TbProduto novo)
    {
        if (novo.NmProduto == string.Empty)
            throw new Exception("Nome é obrigatório");
        if (novo.DsMarca == string.Empty)
            throw new Exception("Marca é obrigatório!!");
        
        return db.Alterar(id, novo);
    }



    }
}