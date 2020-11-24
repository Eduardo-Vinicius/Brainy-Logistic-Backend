using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public partial class Qtdfechada
    {
        [Column(TypeName = "bigint(21)")]
        public long Quantidade { get; set; }
    }
}
