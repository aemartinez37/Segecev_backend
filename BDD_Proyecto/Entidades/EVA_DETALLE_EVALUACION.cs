namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_DETALLE_EVALUACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVA_DETALLE_EVALUACION()
        {
            EVA_RESPUESTA_CUESTIONARIO = new HashSet<EVA_RESPUESTA_CUESTIONARIO>();
        }

        [Key]
        public int COD_DETALLE_EVALUACION { get; set; }

        [Required]
        [StringLength(20)]
        public string COD_EVALUACION { get; set; }

        [Required]
        [StringLength(30)]
        public string COD_CUESTIONARIO { get; set; }

        [StringLength(10)]
        public string COD_ROL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PONDERACION { get; set; }

        public virtual EVA_CUESTIONARIO EVA_CUESTIONARIO { get; set; }

        public virtual EVA_EVALUACION EVA_EVALUACION { get; set; }

        public virtual SEG_ROL SEG_ROL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_RESPUESTA_CUESTIONARIO> EVA_RESPUESTA_CUESTIONARIO { get; set; }
    }
}
