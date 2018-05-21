namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVA_RESPUESTA_PREGUNTA
    {
        [Key]
        public int COD_REGISTRO_RESPUESTAS { get; set; }

        public int COD_PREGUNTA { get; set; }

        [StringLength(20)]
        public string COD_PERSONA { get; set; }

        public int RESPUESTA { get; set; }

        public virtual EVA_PREGUNTA EVA_PREGUNTA { get; set; }

        public virtual INS_PERSONA INS_PERSONA { get; set; }
    }
}
