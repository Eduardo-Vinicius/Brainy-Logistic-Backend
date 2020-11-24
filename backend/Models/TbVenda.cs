using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_venda")]
    public partial class TbVenda
    {
        public TbVenda()
        {
            TbVendaItem = new HashSet<TbVendaItem>();
        }

        [Key]
        [Column("id_venda", TypeName = "int(11)")]
        public int IdVenda { get; set; }
        [Column("ds_valor", TypeName = "decimal(10,2)")]
        public decimal DsValor { get; set; }
        [Column("dt_venda", TypeName = "datetime")]
        public DateTime DtVenda { get; set; }
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbVenda))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbVenda))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        [InverseProperty("IdVendaNavigation")]
        public virtual ICollection<TbVendaItem> TbVendaItem { get; set; }
    }
}
