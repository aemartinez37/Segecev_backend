namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_FUNCIONALIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_FUNCIONALIDAD()
        {
            SEG_PERFIL_FUNCIONALIDAD = new HashSet<SEG_PERFIL_FUNCIONALIDAD>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string COD_MODULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEC_FUNCIONALIDAD { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(200)]
        public string URL { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual SEG_MODULO SEG_MODULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PERFIL_FUNCIONALIDAD> SEG_PERFIL_FUNCIONALIDAD { get; set; }
    }
}
