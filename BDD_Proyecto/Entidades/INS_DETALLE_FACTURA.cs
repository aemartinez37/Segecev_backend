namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_DETALLE_FACTURA
    {
        [Key]
        public int COD_DETALLE { get; set; }

        [StringLength(10)]
        public string COD_FACTURA { get; set; }

        public int? COD_MATRICULA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VALOR_UNITARIO { get; set; }

        public int? CANTIDAD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DESCUENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VALOR_TOTAL { get; set; }

        public virtual INS_FACTURA INS_FACTURA { get; set; }

        public virtual INS_MATRICULA INS_MATRICULA { get; set; }
    }
}
