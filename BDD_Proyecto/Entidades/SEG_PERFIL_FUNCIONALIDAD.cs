namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_PERFIL_FUNCIONALIDAD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string COD_PERFIL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string COD_MODULO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEC_FUNCIONALIDAD { get; set; }

        [Required]
        [StringLength(3)]
        public string ESTADO { get; set; }

        public virtual SEG_FUNCIONALIDAD SEG_FUNCIONALIDAD { get; set; }

        public virtual SEG_PERFIL SEG_PERFIL { get; set; }
    }
}
