using System.Collections.Generic;
using System.Linq;


namespace backend.Database
{
    public class FuncionarioDatabase
    {

        Models.opeContext db = new Models.opeContext();
        public Models.TbFuncionario Salvar (Models.TbFuncionario func)
        {
            db.Add(func);
            db.SaveChanges();

            
            return func;
        }

        public List<Models.TbFuncionario> Listar()
        {
            List<Models.TbFuncionario> f = db.TbFuncionario.ToList();
            return f;
        }

        
        public Models.TbFuncionario Deletar(int id)
            {
                Models.TbFuncionario func = db.TbFuncionario.FirstOrDefault(x => x.IdFuncionario == id);

                if (func != null){
                    db.TbFuncionario.Remove(func);
                    db.SaveChanges();
                }
                return func;
            }
        public Models.TbFuncionario Alterar(int id, Models.TbFuncionario novo)
            {
                Models.TbFuncionario func = db.TbFuncionario.FirstOrDefault(x => x.IdFuncionario == id);

                if (func != null){
                    
                    func.NmFuncionario = novo.NmFuncionario;
                    func.DsCpf = novo.DsCpf;
                    func.DsRg = novo.DsRg;
                    func.DsEndereco = novo.DsEndereco;
                    func.DsCep = novo.DsCep;
                    func.DsEmail = novo.DsEmail;
                    func.DsTelefone = novo.DsTelefone;
                    func.DsCargo = novo.DsCargo;
                    func.NmUsuario = novo.NmUsuario;
                    func.DsSenha = novo.DsSenha;
                    func.DtNascimento = novo.DtNascimento;
                    func.DtContratacao = novo.DtContratacao;
                    func.DsNumero= novo.DsNumero;
                    func.DsLocalidade = novo.DsLocalidade;
                    func.DsUf = novo.DsUf;
                    func.DsBairro = novo.DsBairro;





                    db.SaveChanges();

                }

                return func;
            }
    }
}