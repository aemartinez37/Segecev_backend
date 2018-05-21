namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_MATRICULA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_MATRICULA()
        {
            INS_CALIFICACION = new HashSet<INS_CALIFICACION>();
            INS_DETALLE_FACTURA = new HashSet<INS_DETALLE_FACTURA>();
        }

        [Key]
        public int COD_MATRICULA { get; set; }

        [StringLength(10)]
        public string COD_CLASE { get; set; }

        public int? COD_CURSO { get; set; }

        [StringLength(20)]
        public string COD_ALUMNO { get; set; }

        public DateTime? FECHA_REALIZA { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_CALIFICACION> INS_CALIFICACION { get; set; }

        public virtual INS_CLASE INS_CLASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_DETALLE_FACTURA> INS_DETALLE_FACTURA { get; set; }

        public virtual INS_PERSONA INS_PERSONA { get; set; }
    }
}
