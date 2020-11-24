using System;
using System.Collections.Generic;

namespace backend.Utils

{
    public class FornecedorConversor
    {
        public Models.TbFornecedor ParaTabela(Models.Request.FornecedorRequest request)
        {
            Models.TbFornecedor ln = new Models.TbFornecedor();
            ln.NmFornecedor = request.Nome;
            ln.DsRazaosocial = request.razaosocial;
            ln.DsCep = request.Cep;
            ln.DsCnpj = request.Cnpj;
            ln.DsBairro = request.Bairro;
            ln.DsLocalidade = request.Localidade;
            ln.DsContato = request.Contato;
            ln.DsTelefone = request.Telefone;
            ln.DsEmail = request.Email;
            ln.DsUf = request.Uf;
            ln.DsNumero = request.Numero;
            ln.DsEndereco = request.Endereco;
            //ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.FornecedorResponse ParaResponse (Models.TbFornecedor ln)
        {
            Models.Response.FornecedorResponse resp = new Models.Response.FornecedorResponse();
            resp.Id = ln.IdFornecedor;
            resp.Nome = ln.NmFornecedor;
            resp.Cep = ln.DsCep;
            resp.Cnpj = ln.DsCnpj;
            resp.Email = ln.DsEmail;
            resp.Telefone = ln.DsTelefone;
            resp.Bairro = ln.DsBairro;
            resp.Localidade = ln.DsLocalidade;
            resp.razaosocial = ln.DsRazaosocial;
            resp.Contato = ln.DsContato;
            resp.Uf = ln.DsUf;
            resp.Numero = ln.DsNumero;
            resp.Endereco = ln.DsEndereco;


            return resp;
        }

        public List<Models.Response.FornecedorResponse> ParaResponse (List<Models.TbFornecedor> lns)
        {
            List<Models.Response.FornecedorResponse> resp = new List<Models.Response.FornecedorResponse>();
            
            foreach (Models.TbFornecedor item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}