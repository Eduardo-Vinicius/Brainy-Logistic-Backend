using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_produto")]
    public partial class TbProduto
    {
        public TbProduto()
        {
            TbOrdemServicoItem = new HashSet<TbOrdemServicoItem>();
            TbVendaItem = new HashSet<TbVendaItem>();
        }

        [Key]
        [Column("id_produto", TypeName = "int(11)")]
        public int IdProduto { get; set; }
        [Required]
        [Column("nm_produto", TypeName = "varchar(100)")]
        public string NmProduto { get; set; }
        [Required]
        [Column("ds_marca", TypeName = "varchar(150)")]
        public string DsMarca { get; set; }
        [Column("dt_compra", TypeName = "datetime")]
        public DateTime DtCompra { get; set; }
        [Column("vl_venda", TypeName = "decimal(10,2)")]
        public decimal VlVenda { get; set; }
        [Column("ds_qtd", TypeName = "int(11)")]
        public int DsQtd { get; set; }

        [InverseProperty("IdProdutoNavigation")]
        public virtual ICollection<TbOrdemServicoItem> TbOrdemServicoItem { get; set; }
        [InverseProperty("IdProdutoNavigation")]
        public virtual ICollection<TbVendaItem> TbVendaItem { get; set; }
    }
}
