using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class ClienteDatabase
    {

        Models.opeContext db = new Models.opeContext();


        public Models.TbCliente Salvar (Models.TbCliente cl)
        {
            db.Add(cl);
            db.SaveChanges();

            return cl;
        }

        public List<Models.TbCliente> Listar()
        {
            List<Models.TbCliente> clientes = db.TbCliente.ToList();
            return clientes;
        }
      

        public List<Models.TbCliente> ListByFilter(string nome)
        {
            List<Models.TbCliente> clientes = db.TbCliente.Where(x => x.NmCliente == nome).ToList();
            return clientes;
        }

        public Models.TbCliente Deletar(int id)
            {
                Models.TbCliente cliente = db.TbCliente.FirstOrDefault(x => x.IdCliente == id);

                if (cliente != null){
                    db.TbCliente.Remove(cliente);
                    db.SaveChanges();
                }
                return cliente;
            }
        public Models.TbCliente Alterar(int id, Models.TbCliente novo)
            {
                Models.TbCliente cliente = db.TbCliente.FirstOrDefault(x => x.IdCliente == id);

                if (cliente != null){
                    
                    cliente.NmCliente = novo.NmCliente;
                    cliente.DsEmail = novo.DsEmail;
                    cliente.DsCpf = novo.DsCpf;
                    cliente.DsCep = novo.DsCep;
                    cliente.DsEndereco = novo.DsEndereco;
                    cliente.DsTelefone = novo.DsTelefone;
                    cliente.DsRg = novo.DsRg;
                    cliente.DsBairro = novo.DsBairro;
                    cliente.DsNumero = novo.DsNumero;
                    cliente.DsUf = novo.DsUf;
                    cliente.DsBicicleta = novo.DsBicicleta;
                    cliente.DsLocalidade = novo.DsLocalidade;
                    
                    db.SaveChanges();

                }

                return cliente;
            }
    }
}