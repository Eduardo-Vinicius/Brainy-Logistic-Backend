// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;


// namespace backend.Database
// {
//     public class EstoqueDatabase
//     {

//         Models.opeContext db = new Models.opeContext();
//         public Models.TbEstoque Salvar (Models.TbEstoque est)
//         {
//             db.Add(est);
//             db.SaveChanges();
//             return est;
//         }

//         public List<Models.Estoqueview> Listar()
//         {
//             List<Models.Estoqueview> est = db.Estoqueview.ToList();
//             return est;
//         }

        
//         public Models.TbEstoque Deletar(int id)
//             {
//                 Models.TbEstoque est = db.TbEstoque.FirstOrDefault(x => x.IdEstoque == id);

//                 if (est != null){
//                     db.TbEstoque.Remove(est);
//                     db.SaveChanges();
//                 }
//                 return est;
//             }
//         public Models.TbEstoque Alterar(int id, Models.TbEstoque novo)
//             {
//                 Models.TbEstoque forn = db.TbEstoque.FirstOrDefault(x => x.IdEstoque == id);

//                 if (forn != null){
                    
               
//                     forn.DsLocal = novo.DsLocal;
//                     forn.DsQtd = novo.DsQtd;
//                     forn.IdProduto = novo.IdProduto;
//                     forn.VlVenda = novo.VlVenda;
                     
//                     db.SaveChanges();

//                 }

//                 return forn;
//             }
//     }
// }