namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_CLASE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_CLASE()
        {
            EVA_EVALUACION = new HashSet<EVA_EVALUACION>();
            INS_HORARIO = new HashSet<INS_HORARIO>();
            INS_MATRICULA = new HashSet<INS_MATRICULA>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string COD_CLASE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CURSO { get; set; }

        [StringLength(20)]
        public string COD_DOCENTE { get; set; }

        public DateTime FEC_INI { get; set; }

        public DateTime FEC_FIN { get; set; }

        [StringLength(3)]
        public string MODALIDAD { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVA_EVALUACION> EVA_EVALUACION { get; set; }

        public virtual INS_CURSO INS_CURSO { get; set; }

        public virtual INS_PERSONA INS_PERSONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_HORARIO> INS_HORARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_MATRICULA> INS_MATRICULA { get; set; }
    }
}
