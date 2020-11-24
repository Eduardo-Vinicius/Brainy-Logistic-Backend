using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class VendaDatabase
    {

        Models.opeContext db = new Models.opeContext();


        public Models.TbVenda Salvar (Models.TbVenda cl)
        {
            db.Add(cl);
            db.SaveChanges();

            return cl;
        }

        public List<Models.TbVenda> Listar()
        {
            List<Models.TbVenda> clientes = db.TbVenda.ToList();
            return clientes;
        }
      

        public List<Models.TbVenda> ListByFilter(string nome)
        {
            List<Models.TbVenda> clientes = db.TbVenda.ToList();
            return clientes;
        }

        public Models.TbVenda Deletar(int id)
            {
                Models.TbVenda venda = db.TbVenda.FirstOrDefault(x => x.IdVenda == id);

                if (venda != null){
                    db.TbVenda.Remove(venda);
                    db.SaveChanges();
                }
                return venda;
            }
        public Models.TbVenda Alterar(int id, Models.TbVenda novo)
            {
                Models.TbVenda venda = db.TbVenda.FirstOrDefault(x => x.IdVenda == id);

                if (venda != null){

                    venda.IdCliente = novo.IdCliente;
                    venda.IdFuncionario = novo.IdFuncionario;
                    venda.DsValor = novo.DsValor;
                    venda.DtVenda = novo.DtVenda;
                    db.SaveChanges();

                }

                return venda;
            }
    }
}