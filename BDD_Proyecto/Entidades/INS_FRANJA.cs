namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_FRANJA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_FRANJA()
        {
            INS_HORARIO = new HashSet<INS_HORARIO>();
        }

        [Key]
        public int COD_FRANJA { get; set; }

        public DateTime INCIO { get; set; }

        public DateTime FIN { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_HORARIO> INS_HORARIO { get; set; }
    }
}
