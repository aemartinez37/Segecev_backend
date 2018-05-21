namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_ROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_ROL()
        {
            EVA_DETALLE_EVALUACION = new HashSet<EVA_DETALLE_EVALUACION>();
            INS_PERSONA_USUARIO = new HashSet<INS_PERSONA_USUARIO>();
        }

        [Key]
        [StringLength(10)]
        public string COD_ROL { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_DETALLE_EVALUACION> EVA_DETALLE_EVALUACION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PERSONA_USUARIO> INS_PERSONA_USUARIO { get; set; }
    }
}
