namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_PREREQUISITO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CURSO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_PROGRAMA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_CURSO_PREV { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_PROGRAMA_PREV { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual INS_PROGRAMA_CURSO INS_PROGRAMA_CURSO { get; set; }

        public virtual INS_PROGRAMA_CURSO INS_PROGRAMA_CURSO1 { get; set; }
    }
}
