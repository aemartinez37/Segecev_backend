namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_PERSONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_PERSONA()
        {
            EVA_RESPUESTA_CUESTIONARIO = new HashSet<EVA_RESPUESTA_CUESTIONARIO>();
            EVA_RESPUESTA_PREGUNTA = new HashSet<EVA_RESPUESTA_PREGUNTA>();
            INS_CLASE = new HashSet<INS_CLASE>();
            INS_MATRICULA = new HashSet<INS_MATRICULA>();
            INS_PERSONA_USUARIO = new HashSet<INS_PERSONA_USUARIO>();
        }

        [Key]
        [StringLength(20)]
        public string COD_PERSONA { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [StringLength(20)]
        public string APELLIDO { get; set; }

        [Required]
        [StringLength(50)]
        public string DIRECCION { get; set; }

        [Required]
        [StringLength(10)]
        public string TELEFONO { get; set; }

        public DateTime? FEC_NAC { get; set; }

        [StringLength(3)]
        public string TIPO { get; set; }

        [StringLength(3)]
        public string GENERO { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_RESPUESTA_CUESTIONARIO> EVA_RESPUESTA_CUESTIONARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_RESPUESTA_PREGUNTA> EVA_RESPUESTA_PREGUNTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_CLASE> INS_CLASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_MATRICULA> INS_MATRICULA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PERSONA_USUARIO> INS_PERSONA_USUARIO { get; set; }
    }
}
