namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_CALIFICACION
    {
        [Key]
        public int COD_CALIFICACION { get; set; }

        public int? COD_MATRICULA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR_CALIFICACION { get; set; }

        public int? PORCENTAJE_PESO { get; set; }

        public virtual INS_MATRICULA INS_MATRICULA { get; set; }
    }
}
