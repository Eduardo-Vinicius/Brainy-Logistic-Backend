using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_ordem_servico_item")]
    public partial class TbOrdemServicoItem
    {
        [Key]
        [Column("id_ordem_servico_item", TypeName = "int(11)")]
        public int IdOrdemServicoItem { get; set; }
        [Column("id_ordem_servico", TypeName = "int(11)")]
        public int IdOrdemServico { get; set; }
        [Column("id_produto", TypeName = "int(11)")]
        public int IdProduto { get; set; }
        [Column("ds_qtd", TypeName = "int(11)")]
        public int DsQtd { get; set; }

        [ForeignKey(nameof(IdOrdemServico))]
        [InverseProperty(nameof(TbOrdemServico.TbOrdemServicoItem))]
        public virtual TbOrdemServico IdOrdemServicoNavigation { get; set; }
        [ForeignKey(nameof(IdProduto))]
        [InverseProperty(nameof(TbProduto.TbOrdemServicoItem))]
        public virtual TbProduto IdProdutoNavigation { get; set; }
    }
}
