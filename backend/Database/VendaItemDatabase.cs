using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class VendaItemDatabase
    {

        Models.opeContext db = new Models.opeContext();


        public Models.TbVendaItem Salvar (Models.TbVendaItem cl)
        {
            db.Add(cl);
            db.SaveChanges();

            return cl;
        }

        public List<Models.TbVendaItem> Listar()
        {
            List<Models.TbVendaItem> venda_item = db.TbVendaItem.ToList();
            return venda_item;
        }
      

        public List<Models.TbVendaItem> ListByFilter(string nome)
        {
            List<Models.TbVendaItem> venda_item = db.TbVendaItem.ToList();
            return venda_item;
        }

        public Models.TbVendaItem Deletar(int id)
            {
                Models.TbVendaItem venda_item = db.TbVendaItem.FirstOrDefault(x => x.IdVendaItem == id);

                if (venda_item != null){
                    db.TbVendaItem.Remove(venda_item);
                    db.SaveChanges();
                }
                return venda_item;
            }
        public Models.TbVendaItem Alterar(int id, Models.TbVendaItem novo)
            {
                Models.TbVendaItem venda_item = db.TbVendaItem.FirstOrDefault(x => x.IdVendaItem == id);

                if (venda_item != null){
                    venda_item.DsQtd = novo.DsQtd;
                    venda_item.VlTotal = novo.VlTotal;
                    venda_item.IdProduto = novo.IdProduto;
                    venda_item.IdVenda = novo.IdVenda;
                    db.SaveChanges();

                }

                return venda_item;
            }
    }
}