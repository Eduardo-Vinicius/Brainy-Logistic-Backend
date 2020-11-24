using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_compra")]
    public partial class TbCompra
    {
        [Key]
        [Column("id_compra", TypeName = "int(11)")]
        public int IdCompra { get; set; }
        [Column("dt_compra", TypeName = "datetime")]
        public DateTime DtCompra { get; set; }
        [Column("vl_compra", TypeName = "decimal(10,2)")]
        public decimal VlCompra { get; set; }
        [Column("vl_venda", TypeName = "decimal(10,2)")]
        public decimal VlVenda { get; set; }
        [Column("ds_qtd", TypeName = "int(11)")]
        public int DsQtd { get; set; }
        [Required]
        [Column("nm_produto", TypeName = "varchar(150)")]
        public string NmProduto { get; set; }
        [Required]
        [Column("ds_marca", TypeName = "varchar(150)")]
        public string DsMarca { get; set; }
        [Column("id_fornecedor", TypeName = "int(11)")]
        public int IdFornecedor { get; set; }
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }

        [ForeignKey(nameof(IdFornecedor))]
        [InverseProperty(nameof(TbFornecedor.TbCompra))]
        public virtual TbFornecedor IdFornecedorNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbCompra))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
