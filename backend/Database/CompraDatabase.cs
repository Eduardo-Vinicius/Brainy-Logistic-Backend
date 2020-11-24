using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class CompraDatabase
    {

        Models.opeContext db = new Models.opeContext();


        public Models.TbCompra Salvar (Models.TbCompra cl)
        {
            db.Add(cl);
            db.SaveChanges();

            return cl;
        }

        public List<Models.TbCompra> Listar()
        {
            List<Models.TbCompra> compras = db.TbCompra.ToList();
            return compras;
        }
      

        // public List<Models.TbCliente> ListByFilter(string nome)
        // {
        //     List<Models.TbCliente> clientes = db.TbCliente.ToList();
        //     return clientes;
        // }

        public Models.TbCompra Deletar(int id)
            {
                Models.TbCompra compra = db.TbCompra.FirstOrDefault(x => x.IdCompra == id);

                if (compra != null){
                    db.TbCompra.Remove(compra);
                    db.SaveChanges();
                }
                return compra;
            }
        // public Models.TbCliente Alterar(int id, Models.TbCliente novo)
        //     {
        //         Models.TbCliente cliente = db.TbCliente.FirstOrDefault(x => x.IdCliente == id);

        //         if (cliente != null){
                    
        //             cliente.NmCliente = novo.NmCliente;
        //             cliente.DsEmail = novo.DsEmail;
        //             cliente.DsCpf = novo.DsCpf;
        //             cliente.DsCep = novo.DsCep;
        //             cliente.DsEndereco = novo.DsEndereco;
        //             cliente.DsTelefone = novo.DsTelefone;
        //             cliente.DsRg = novo.DsRg;
        //             cliente.DsBairro = novo.DsBairro;
        //             cliente.DsNumero = novo.DsNumero;
        //             cliente.DsUf = novo.DsUf;
        //             cliente.DsBicicleta = novo.DsBicicleta;
        //             cliente.DsLocalidade = novo.DsLocalidade;
                    
        //             db.SaveChanges();

        //         }

        //         return cliente;
        //     }
    }
}