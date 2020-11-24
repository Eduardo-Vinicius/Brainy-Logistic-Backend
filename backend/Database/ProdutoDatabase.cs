using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class ProdutoDatabase
    {

        Models.opeContext db = new Models.opeContext();


        public Models.TbProduto Salvar (Models.TbProduto prod)
        {
            db.Add(prod);
            db.SaveChanges();

            
            return prod;
        }

        public List<Models.TbProduto> Listar()
        {
            List<Models.TbProduto> p = db.TbProduto.ToList();
            return p;
        }

         public Models.TbProduto Deletar(int id)
            {
                Models.TbProduto prod = db.TbProduto.FirstOrDefault(x => x.IdProduto == id);

                if (prod != null){
                    db.TbProduto.Remove(prod);
                    db.SaveChanges();
                }
                return prod;
            }
        public Models.TbProduto Alterar(int id, Models.TbProduto novo)
            {
                Models.TbProduto prod = db.TbProduto.FirstOrDefault(x => x.IdProduto == id);

                if (prod != null){
                    
                    prod.NmProduto = novo.NmProduto;
                    prod.VlVenda = novo.VlVenda;
                    prod.DsMarca = novo.DsMarca;
                    prod.DsQtd = novo.DsQtd;
                    prod.DtCompra = novo.DtCompra;
                    db.SaveChanges();

                }

                return prod;
            }
        
    }
}