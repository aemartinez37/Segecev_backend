namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_PROGRAMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_PROGRAMA()
        {
            INS_PROGRAMA_CURSO = new HashSet<INS_PROGRAMA_CURSO>();
        }

        [Key]
        public int COD_PROGRAMA { get; set; }

        [Required]
        [StringLength(50)]
        public string TITULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PROGRAMA_CURSO> INS_PROGRAMA_CURSO { get; set; }
    }
}
