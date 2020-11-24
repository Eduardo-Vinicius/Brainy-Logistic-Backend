using System.Collections.Generic;

namespace backend.Utils

{
    public class FuncionarioConversor
    {
        public Models.TbFuncionario ParaTabela(Models.Request.FuncionarioRequest request)
        {
            Models.TbFuncionario func = new Models.TbFuncionario();
            func.NmFuncionario = request.Nome;
            func.DsCpf = request.Cpf;
            func.DsRg = request.Rg;
            func.DsEndereco = request.Endereco;
            func.DsCep = request.Cep;
            func.DsEmail = request.Email;
            func.DsCargo = request.Cargo;
            func.DsTelefone = request.Telefone;
            func.NmUsuario = request.Usuario;
            func.DsSenha = request.Senha;
            func.DsUf = request.Uf;
            func.DsLocalidade = request.Localidade;
            func.DsBairro = request.Bairro;
            func.DsNumero = request.Numero;
            func.DtContratacao = request.DataContratacao;
            func.DtNascimento = request.DataNascimento;


          

            return func;
        }

        public Models.Response.FuncionarioResponse ParaResponse (Models.TbFuncionario ln)
        {
            Models.Response.FuncionarioResponse resp = new Models.Response.FuncionarioResponse();
            resp.Id = ln.IdFuncionario;
            resp.Nome = ln.NmFuncionario;
            resp.Cpf = ln.DsCpf;
            resp.Rg = ln.DsRg;
            resp.Cargo = ln.DsCargo;
            resp.Email = ln.DsEmail;
            resp.Endereco = ln.DsEndereco;
            resp.Cep = ln.DsCep;
            resp.Telefone = ln.DsTelefone;
            resp.Usuario = ln.NmUsuario;
            resp.Senha = ln.DsSenha;
            resp.Uf = ln.DsUf;
            resp.Bairro = ln.DsBairro;
            resp.Numero = ln.DsNumero;
            resp.Localidade = ln.DsLocalidade;
            resp.DataNascimento = ln.DtNascimento;
            resp.DataContratacao = ln.DtContratacao;
            return resp;
        }

        public List<Models.Response.FuncionarioResponse> ParaResponse (List<Models.TbFuncionario> lns)
        {
            List<Models.Response.FuncionarioResponse> resp = new List<Models.Response.FuncionarioResponse>();
            
            foreach (Models.TbFuncionario item in lns)
            {
                resp.Add(
                this.ParaResponse(item));
            }

            return resp;
        }

        
    }
}