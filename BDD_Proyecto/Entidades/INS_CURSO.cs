namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INS_CURSO()
        {
            INS_CLASE = new HashSet<INS_CLASE>();
            INS_PROGRAMA_CURSO = new HashSet<INS_PROGRAMA_CURSO>();
            INS_TEMA = new HashSet<INS_TEMA>();
        }

        [Key]
        public int COD_CURSO { get; set; }

        public int? COD_AREA { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COSTO { get; set; }

        public int? HORAS_DURACION { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual INS_AREA INS_AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_CLASE> INS_CLASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_PROGRAMA_CURSO> INS_PROGRAMA_CURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INS_TEMA> INS_TEMA { get; set; }
    }
}
