namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_PERFIL()
        {
            SEG_PERFIL_FUNCIONALIDAD = new HashSet<SEG_PERFIL_FUNCIONALIDAD>();
            SEG_USUARIO = new HashSet<SEG_USUARIO>();
        }

        [Key]
        [StringLength(20)]
        public string COD_PERFIL { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PERFIL_FUNCIONALIDAD> SEG_PERFIL_FUNCIONALIDAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_USUARIO> SEG_USUARIO { get; set; }
    }
}
