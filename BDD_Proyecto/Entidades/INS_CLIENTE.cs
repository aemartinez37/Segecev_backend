namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_CLIENTE()
        {
            INS_FACTURA = new HashSet<INS_FACTURA>();
        }

        [Key]
        public int COD_CLIENTE { get; set; }

        [Required]
        [StringLength(100)]
        public string RAZON_SOCIAL { get; set; }

        [Required]
        [StringLength(13)]
        public string NUM_DOCUMENTO { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [StringLength(30)]
        public string CORREO { get; set; }

        [StringLength(10)]
        public string TELEFONO { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_FACTURA> INS_FACTURA { get; set; }
    }
}
