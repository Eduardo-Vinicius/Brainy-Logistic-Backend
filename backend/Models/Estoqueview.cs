using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public partial class Estoqueview
    {
        [Column("id_estoque", TypeName = "int(11)")]
        public int IdEstoque { get; set; }
        [Required]
        [Column("nm_produto", TypeName = "varchar(100)")]
        public string NmProduto { get; set; }
        [Required]
        [Column("ds_marca", TypeName = "varchar(150)")]
        public string DsMarca { get; set; }
        [Column("ds_local", TypeName = "varchar(100)")]
        public string DsLocal { get; set; }
        [Column("sum(e.ds_qtd)", TypeName = "decimal(32,0)")]
        public decimal? SumEDsQtd { get; set; }
        [Column("vl_venda", TypeName = "decimal(10,2)")]
        public decimal VlVenda { get; set; }
        [Required]
        [Column("nm_fornecedor", TypeName = "varchar(100)")]
        public string NmFornecedor { get; set; }
        [Column("dt_compra", TypeName = "datetime")]
        public DateTime DtCompra { get; set; }
    }
}
