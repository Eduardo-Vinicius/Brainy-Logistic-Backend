using System.Collections.Generic;

namespace backend.Utils

{
    public class ClienteConversor
    {
        public Models.TbCliente ParaTabela(Models.Request.ClienteRequest request)
        {
            Models.TbCliente ln = new Models.TbCliente();
            ln.NmCliente = request.Nome;
            ln.DsCpf = request.Cpf;
            ln.DsRg = request.Rg;
            ln.DsCep = request.Cep;
            ln.DsEndereco = request.Endereco;
            ln.DsLocalidade = request.Localidade;
            ln.DsNumero = request.Numero;
            ln.DsBairro = request.Bairro;
            ln.DsUf = request.Uf;
            ln.DsTelefone = request.Telefone;
            ln.DsEmail = request.Email;
            ln.DsBicicleta = request.Bicicleta;
            //ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.ClienteResponse ParaResponse (Models.TbCliente ln)
        {
            Models.Response.ClienteResponse resp = new Models.Response.ClienteResponse();
            resp.Id = ln.IdCliente;
            resp.Nome = ln.NmCliente;
            resp.Cep = ln.DsCep;
            resp.Cpf = ln.DsCpf;
            resp.Rg = ln.DsRg;
            resp.Email = ln.DsEmail;
            resp.Endereco = ln.DsEndereco;
            resp.Telefone = ln.DsTelefone;
            resp.Localidade = ln.DsLocalidade;
            resp.Numero = ln.DsNumero;
            resp.Bairro = ln.DsBairro;
            resp.Uf = ln.DsUf;
            resp.Bicicleta = ln.DsBicicleta;

            return resp;
        }

        public List<Models.Response.ClienteResponse> ParaResponse (List<Models.TbCliente> lns)
        {
            List<Models.Response.ClienteResponse> resp = new List<Models.Response.ClienteResponse>();
            
            foreach (Models.TbCliente item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}