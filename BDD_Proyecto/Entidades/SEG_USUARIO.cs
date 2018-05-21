namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_USUARIO()
        {
            INS_PERSONA_USUARIO = new HashSet<INS_PERSONA_USUARIO>();
        }

        [Key]
        [StringLength(20)]
        public string COD_USUARIO { get; set; }

        [StringLength(20)]
        public string COD_PERFIL { get; set; }

        [Required]
        [StringLength(120)]
        public string CORREO_ELECTRONICO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(64)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal INTENTOS_ERRONEOS { get; set; }

        public DateTime? FECHA_ULTIMO_ACCESO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PERSONA_USUARIO> INS_PERSONA_USUARIO { get; set; }

        public virtual SEG_PERFIL SEG_PERFIL { get; set; }
    }
}
