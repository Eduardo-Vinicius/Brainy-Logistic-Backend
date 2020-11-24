using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_ordem_servico")]
    public partial class TbOrdemServico
    {
        public TbOrdemServico()
        {
            TbOrdemServicoItem = new HashSet<TbOrdemServicoItem>();
        }

        [Key]
        [Column("id_ordem_servico", TypeName = "int(11)")]
        public int IdOrdemServico { get; set; }
        [Column("ds_valor", TypeName = "decimal(10,2)")]
        public decimal DsValor { get; set; }
        [Column("dt_ordem_servico", TypeName = "datetime")]
        public DateTime DtOrdemServico { get; set; }
        [Required]
        [Column("ds_status", TypeName = "varchar(100)")]
        public string DsStatus { get; set; }
        [Column("id_funcionario", TypeName = "int(11)")]
        public int IdFuncionario { get; set; }
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("ds_valor_manutencao", TypeName = "decimal(10,2)")]
        public decimal DsValorManutencao { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbOrdemServico))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbOrdemServico))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        [InverseProperty("IdOrdemServicoNavigation")]
        public virtual ICollection<TbOrdemServicoItem> TbOrdemServicoItem { get; set; }
    }
}
