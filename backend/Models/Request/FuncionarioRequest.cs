using System;


namespace backend.Models.Request
{
    public class FuncionarioRequest
    {
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public string Rg {get; set;}
        public string Endereco {get; set;}
        public string Cep {get; set;}
        public string Email {get; set;}
        public string Telefone {get; set;}
        public string Cargo {get; set;}
        public string Usuario {get; set;}
        public string Senha {get; set;}
        public string Uf {get; set;}
        public string Numero {get; set;}
        public string Bairro {get; set;}
        public string Localidade {get; set;}
        public DateTime DataContratacao {get; set;}
        public DateTime DataNascimento {get; set;}
    }
}