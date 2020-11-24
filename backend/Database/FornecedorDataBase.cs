using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace backend.Database
{
    public class FornecedorDatabase
    {

        Models.opeContext db = new Models.opeContext();
        public Models.TbFornecedor Salvar (Models.TbFornecedor forn)
        {
            db.Add(forn);
            db.SaveChanges();

            
            return forn;
        }

        public List<Models.TbFornecedor> Listar()
        {
            List<Models.TbFornecedor> forn = db.TbFornecedor.ToList();
            return forn;
        }

        
        public Models.TbFornecedor Deletar(int id)
            {
                Models.TbFornecedor forn = db.TbFornecedor.FirstOrDefault(x => x.IdFornecedor == id);

                if (forn != null){
                    db.TbFornecedor.Remove(forn);
                    db.SaveChanges();
                }
                return forn;
            }
        public Models.TbFornecedor Alterar(int id, Models.TbFornecedor novo)
            {
                Models.TbFornecedor forn = db.TbFornecedor.FirstOrDefault(x => x.IdFornecedor == id);

                if (forn != null){
                    
                    forn.NmFornecedor = novo.NmFornecedor;
                    forn.DsRazaosocial = novo.DsRazaosocial;
                    forn.DsCnpj = novo.DsCnpj;
                    forn.DsCep = novo.DsCep;
                    forn.DsBairro = novo.DsBairro;
                    forn.DsLocalidade= novo.DsLocalidade;
                    forn.DsContato = novo.DsContato;
                    forn.DsTelefone = novo.DsTelefone;
                    forn.DsUf = novo.DsUf;
                    forn.DsNumero = novo.DsNumero;
                    forn.DsEndereco = novo.DsEndereco;

                     
                    db.SaveChanges();

                }

                return forn;
            }
    }
}