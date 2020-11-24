// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

// namespace backend.Models
// {
//     [Table("tb_estoque")]
//     public partial class TbEstoque
//     {
//         [Key]
//         [Column("id_estoque", TypeName = "int(11)")]
//         public int IdEstoque { get; set; }
//         [Column("ds_local", TypeName = "varchar(100)")]
//         public string DsLocal { get; set; }
//         [Column("ds_qtd", TypeName = "int(11)")]
//         public int DsQtd { get; set; }
//         [Column("vl_venda", TypeName = "decimal(10,2)")]
//         public decimal VlVenda { get; set; }
//         [Column("id_produto", TypeName = "int(11)")]
//         public int IdProduto { get; set; }

//         [ForeignKey(nameof(IdProduto))]
//         [InverseProperty(nameof(TbProduto.TbEstoque))]
//         public virtual TbProduto IdProdutoNavigation { get; set; }
//     }
// }
