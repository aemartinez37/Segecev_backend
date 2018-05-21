namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_TEMA
    {
        [Key]
        [StringLength(10)]
        public string COD_MODULO { get; set; }

        public int? COD_CURSO { get; set; }

        [Required]
        [StringLength(50)]
        public string TITULO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual INS_CURSO INS_CURSO { get; set; }
    }
}
