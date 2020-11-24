// using System;
// using System.Collections.Generic;

// namespace backend.Business
// {
//     public class EstoqueBusiness
//     {
//     Database.EstoqueDatabase db = new Database.EstoqueDatabase();

//     public Models.TbEstoque Salvar (Models.TbEstoque ln)
//     {
        
//         return db.Salvar(ln);

//     }

//     public List<Models.Estoqueview> Listar()
//     {
//         return db.Listar();
//     }

//     public Models.TbEstoque Deletar(int id)
//     {
//         return db.Deletar(id);
//     }
//     public Models.TbEstoque Alterar(int id, Models.TbEstoque novo)
//     {
//        return db.Alterar(id, novo);
//     }



//     }
// }