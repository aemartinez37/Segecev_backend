namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_FACTURA()
        {
            INS_DETALLE_FACTURA = new HashSet<INS_DETALLE_FACTURA>();
            INS_FACTURA_FORMAPAGO = new HashSet<INS_FACTURA_FORMAPAGO>();
        }

        [Key]
        [StringLength(10)]
        public string COD_FACTURA { get; set; }

        public int? COD_CLIENTE { get; set; }

        public DateTime FECHA_EMISION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SUBTOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal IVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DESCUENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TOTAL { get; set; }

        [StringLength(120)]
        public string OBSERVACION { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual INS_CLIENTE INS_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_DETALLE_FACTURA> INS_DETALLE_FACTURA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_FACTURA_FORMAPAGO> INS_FACTURA_FORMAPAGO { get; set; }
    }
}
