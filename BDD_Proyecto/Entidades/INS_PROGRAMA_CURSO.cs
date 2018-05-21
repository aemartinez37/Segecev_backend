namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_PROGRAMA_CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_PROGRAMA_CURSO()
        {
            INS_PREREQUISITO = new HashSet<INS_PREREQUISITO>();
            INS_PREREQUISITO1 = new HashSet<INS_PREREQUISITO>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_PROGRAMA { get; set; }

        public virtual INS_CURSO INS_CURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PREREQUISITO> INS_PREREQUISITO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PREREQUISITO> INS_PREREQUISITO1 { get; set; }

        public virtual INS_PROGRAMA INS_PROGRAMA { get; set; }
    }
}
