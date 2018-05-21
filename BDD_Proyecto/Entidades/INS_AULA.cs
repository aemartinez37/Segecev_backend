namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_AULA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_AULA()
        {
            INS_HORARIO = new HashSet<INS_HORARIO>();
        }

        [Key]
        public int COD_AULA { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPCION { get; set; }

        [StringLength(3)]
        public string TIPO { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_HORARIO> INS_HORARIO { get; set; }
    }
}
