namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_PREGUNTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVA_PREGUNTA()
        {
            EVA_RESPUESTA_PREGUNTA = new HashSet<EVA_RESPUESTA_PREGUNTA>();
        }

        [Key]
        public int COD_PREGUNTA { get; set; }

        [StringLength(30)]
        public string COD_CUESTIONARIO { get; set; }

        [Required]
        [StringLength(200)]
        public string ENUNCIADO { get; set; }

        public virtual EVA_CUESTIONARIO EVA_CUESTIONARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_RESPUESTA_PREGUNTA> EVA_RESPUESTA_PREGUNTA { get; set; }
    }
}
