using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbOrdemServico = new HashSet<TbOrdemServico>();
            TbVenda = new HashSet<TbVenda>();
        }

        [Key]
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nm_cliente", TypeName = "varchar(100)")]
        public string NmCliente { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(15)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(15)")]
        public string DsRg { get; set; }
        [Required]
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
        [Column("ds_uf", TypeName = "varchar(100)")]
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
        [Column("ds_bicicleta", TypeName = "varchar(50)")]
        public string DsBicicleta { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbOrdemServico> TbOrdemServico { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbVenda> TbVenda { get; set; }
    }
}
