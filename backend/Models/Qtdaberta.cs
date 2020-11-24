using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public partial class Qtdaberta
    {
        [Column(TypeName = "bigint(21)")]
        public long Quantidade { get; set; }
    }
}
