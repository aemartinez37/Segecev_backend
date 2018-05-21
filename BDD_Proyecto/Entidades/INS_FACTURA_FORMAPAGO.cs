namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_FACTURA_FORMAPAGO
    {
        [Key]
        public int COD_FACTURA_FORMAPAGO { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_FACTURA { get; set; }

        [Required]
        [StringLength(3)]
        public string FORMA_PAGO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VALOR { get; set; }

        public virtual INS_FACTURA INS_FACTURA { get; set; }
    }
}
