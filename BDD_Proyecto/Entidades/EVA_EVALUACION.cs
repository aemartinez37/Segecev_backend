namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_EVALUACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVA_EVALUACION()
        {
            EVA_DETALLE_EVALUACION = new HashSet<EVA_DETALLE_EVALUACION>();
        }

        [Key]
        [StringLength(20)]
        public string COD_EVALUACION { get; set; }

        [StringLength(10)]
        public string COD_CLASE { get; set; }

        public int? INS_COD_CURSO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_DETALLE_EVALUACION> EVA_DETALLE_EVALUACION { get; set; }

        public virtual INS_CLASE INS_CLASE { get; set; }
    }
}
