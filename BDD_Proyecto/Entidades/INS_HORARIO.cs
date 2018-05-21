namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_HORARIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_FRANJA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_AULA { get; set; }

        [StringLength(10)]
        public string COD_CLASE { get; set; }

        public int? COD_CURSO { get; set; }

        [StringLength(1)]
        public string DIA { get; set; }

        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual INS_AULA INS_AULA { get; set; }

        public virtual INS_CLASE INS_CLASE { get; set; }

        public virtual INS_FRANJA INS_FRANJA { get; set; }
    }
}
