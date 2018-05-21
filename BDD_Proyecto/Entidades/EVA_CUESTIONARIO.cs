namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_CUESTIONARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVA_CUESTIONARIO()
        {
            EVA_DETALLE_EVALUACION = new HashSet<EVA_DETALLE_EVALUACION>();
            EVA_PREGUNTA = new HashSet<EVA_PREGUNTA>();
        }

        [Key]
        [StringLength(30)]
        public string COD_CUESTIONARIO { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_DETALLE_EVALUACION> EVA_DETALLE_EVALUACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_PREGUNTA> EVA_PREGUNTA { get; set; }
    }
}
