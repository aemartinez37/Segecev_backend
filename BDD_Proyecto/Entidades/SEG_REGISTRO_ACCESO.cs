namespace BDD_Proyecto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_REGISTRO_ACCESO
    {
        [Key]
        public int COD_ACCESO { get; set; }

        [Required]
        [StringLength(10)]
        public string TIPO_ACCESO { get; set; }

        [Required]
        [StringLength(20)]
        public string COD_USUARIO { get; set; }

        [Required]
        [StringLength(15)]
        public string IP { get; set; }

        [StringLength(30)]
        public string FUNCIONALIDAD { get; set; }

        [Required]
        [StringLength(10)]
        public string RESULTADO { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] FECHA { get; set; }
    }
}
