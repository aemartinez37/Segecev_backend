namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INS_PERSONA_USUARIO
    {
        [Key]
        public int COD_PERSONA_USUARIO { get; set; }

        [Required]
        [StringLength(20)]
        public string COD_PERSONA { get; set; }

        [Required]
        [StringLength(20)]
        public string COD_USUARIO { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_ROL { get; set; }

        public virtual INS_PERSONA INS_PERSONA { get; set; }

        public virtual SEG_ROL SEG_ROL { get; set; }

        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
    }
}
