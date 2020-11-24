using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_venda_item")]
    public partial class TbVendaItem
    {
        [Key]
        [Column("id_venda_item", TypeName = "int(11)")]
        public int IdVendaItem { get; set; }
        [Column("id_produto", TypeName = "int(11)")]
        public int IdProduto { get; set; }
        [Column("id_venda", TypeName = "int(11)")]
        public int IdVenda { get; set; }
        [Column("ds_qtd", TypeName = "int(11)")]
        public int DsQtd { get; set; }
        [Column("vl_total", TypeName = "decimal(10,2)")]
        public decimal VlTotal { get; set; }

        [ForeignKey(nameof(IdProduto))]
        [InverseProperty(nameof(TbProduto.TbVendaItem))]
        public virtual TbProduto IdProdutoNavigation { get; set; }
        [ForeignKey(nameof(IdVenda))]
        [InverseProperty(nameof(TbVenda.TbVendaItem))]
        public virtual TbVenda IdVendaNavigation { get; set; }
    }
}
