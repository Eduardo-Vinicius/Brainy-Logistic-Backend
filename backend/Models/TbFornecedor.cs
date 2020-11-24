using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_fornecedor")]
    public partial class TbFornecedor
    {
        public TbFornecedor()
        {
            TbCompra = new HashSet<TbCompra>();
        }

        [Key]
        [Column("id_fornecedor", TypeName = "int(11)")]
        public int IdFornecedor { get; set; }
        [Required]
        [Column("nm_fornecedor", TypeName = "varchar(100)")]
        public string NmFornecedor { get; set; }
        [Required]
        [Column("ds_razaosocial", TypeName = "varchar(200)")]
        public string DsRazaosocial { get; set; }
        [Required]
        [Column("ds_cnpj", TypeName = "varchar(50)")]
        public string DsCnpj { get; set; }
        [Required]
        [Column("ds_cep", TypeName = "varchar(15)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(80)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_bairro", TypeName = "varchar(40)")]
        public string DsBairro { get; set; }
        [Required]
        [Column("ds_localidade", TypeName = "varchar(30)")]
        public string DsLocalidade { get; set; }
        [Required]
        [Column("ds_uf", TypeName = "varchar(2)")]
        public string DsUf { get; set; }
        [Required]
        [Column("ds_numero", TypeName = "varchar(10)")]
        public string DsNumero { get; set; }
        [Required]
        [Column("ds_contato", TypeName = "varchar(80)")]
        public string DsContato { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(25)")]
        public string DsTelefone { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }

        [InverseProperty("IdFornecedorNavigation")]
        public virtual ICollection<TbCompra> TbCompra { get; set; }
    }
}
