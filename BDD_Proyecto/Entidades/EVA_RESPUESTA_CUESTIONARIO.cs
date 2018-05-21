namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_RESPUESTA_CUESTIONARIO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string COD_CURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string COD_CUESTIONARIO { get; set; }

        public int COD_DETALLE_EVALUACION { get; set; }

        [Required]
        [StringLength(20)]
        public string COD_PERSONA { get; set; }

        public DateTime FECHA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CALIFICACION_PROMEDIO { get; set; }

        public virtual EVA_DETALLE_EVALUACION EVA_DETALLE_EVALUACION { get; set; }

        public virtual INS_PERSONA INS_PERSONA { get; set; }
    }
}
