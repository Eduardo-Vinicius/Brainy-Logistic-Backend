using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        public TbFuncionario()
        {
            TbCompra = new HashSet<TbCompra>();
            TbOrdemServico = new HashSet<TbOrdemServico>();
            TbVenda = new HashSet<TbVenda>();
        }

        [Key]
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Required]
        [Column("nm_funcionario", TypeName = "varchar(100)")]
        public string NmFuncionario { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(15)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(15)")]
        public string DsRg { get; set; }
        [Column("ds_cep", TypeName = "varchar(15)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(80)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_localidade", TypeName = "varchar(100)")]
        public string DsLocalidade { get; set; }
        [Required]
        [Column("ds_bairro", TypeName = "varchar(40)")]
        public string DsBairro { get; set; }
        [Required]
        [Column("ds_uf", TypeName = "varchar(2)")]
        public string DsUf { get; set; }
        [Required]
        [Column("ds_numero", TypeName = "varchar(10)")]
        public string DsNumero { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(20)")]
        public string DsTelefone { get; set; }
        [Required]
        [Column("ds_cargo", TypeName = "varchar(100)")]
        public string DsCargo { get; set; }
        [Required]
        [Column("nm_usuario", TypeName = "varchar(50)")]
        public string NmUsuario { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(50)")]
        public string DsSenha { get; set; }
        [Column("dt_contratacao", TypeName = "datetime")]
        public DateTime DtContratacao { get; set; }
        [Column("dt_nascimento", TypeName = "datetime")]
        public DateTime DtNascimento { get; set; }

        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbCompra> TbCompra { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbOrdemServico> TbOrdemServico { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbVenda> TbVenda { get; set; }
    }
}
