namespace BDD_Proyecto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextProyecto : DbContext
    {
        public ContextProyecto()
            : base("name=ContextProyecto")
        {
        }

        public virtual DbSet<EVA_CUESTIONARIO> EVA_CUESTIONARIO { get; set; }
        public virtual DbSet<EVA_DETALLE_EVALUACION> EVA_DETALLE_EVALUACION { get; set; }
        public virtual DbSet<EVA_EVALUACION> EVA_EVALUACION { get; set; }
        public virtual DbSet<EVA_PREGUNTA> EVA_PREGUNTA { get; set; }
        public virtual DbSet<EVA_RESPUESTA_CUESTIONARIO> EVA_RESPUESTA_CUESTIONARIO { get; set; }
        public virtual DbSet<EVA_RESPUESTA_PREGUNTA> EVA_RESPUESTA_PREGUNTA { get; set; }
        public virtual DbSet<INS_AREA> INS_AREA { get; set; }
        public virtual DbSet<INS_AULA> INS_AULA { get; set; }
        public virtual DbSet<INS_CALIFICACION> INS_CALIFICACION { get; set; }
        public virtual DbSet<INS_CLASE> INS_CLASE { get; set; }
        public virtual DbSet<INS_CLIENTE> INS_CLIENTE { get; set; }
        public virtual DbSet<INS_CURSO> INS_CURSO { get; set; }
        public virtual DbSet<INS_DETALLE_FACTURA> INS_DETALLE_FACTURA { get; set; }
        public virtual DbSet<INS_FACTURA> INS_FACTURA { get; set; }
        public virtual DbSet<INS_FACTURA_FORMAPAGO> INS_FACTURA_FORMAPAGO { get; set; }
        public virtual DbSet<INS_FRANJA> INS_FRANJA { get; set; }
        public virtual DbSet<INS_HORARIO> INS_HORARIO { get; set; }
        public virtual DbSet<INS_MATRICULA> INS_MATRICULA { get; set; }
        public virtual DbSet<INS_PERSONA> INS_PERSONA { get; set; }
        public virtual DbSet<INS_PERSONA_USUARIO> INS_PERSONA_USUARIO { get; set; }
        public virtual DbSet<INS_PREREQUISITO> INS_PREREQUISITO { get; set; }
        public virtual DbSet<INS_PROGRAMA> INS_PROGRAMA { get; set; }
        public virtual DbSet<INS_PROGRAMA_CURSO> INS_PROGRAMA_CURSO { get; set; }
        public virtual DbSet<INS_TEMA> INS_TEMA { get; set; }
        public virtual DbSet<SEG_FUNCIONALIDAD> SEG_FUNCIONALIDAD { get; set; }
        public virtual DbSet<SEG_MODULO> SEG_MODULO { get; set; }
        public virtual DbSet<SEG_PERFIL> SEG_PERFIL { get; set; }
        public virtual DbSet<SEG_PERFIL_FUNCIONALIDAD> SEG_PERFIL_FUNCIONALIDAD { get; set; }
        public virtual DbSet<SEG_REGISTRO_ACCESO> SEG_REGISTRO_ACCESO { get; set; }
        public virtual DbSet<SEG_ROL> SEG_ROL { get; set; }
        public virtual DbSet<SEG_USUARIO> SEG_USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EVA_CUESTIONARIO>()
                .Property(e => e.COD_CUESTIONARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_CUESTIONARIO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_CUESTIONARIO>()
                .HasMany(e => e.EVA_DETALLE_EVALUACION)
                .WithRequired(e => e.EVA_CUESTIONARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVA_DETALLE_EVALUACION>()
                .Property(e => e.COD_EVALUACION)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_DETALLE_EVALUACION>()
                .Property(e => e.COD_CUESTIONARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_DETALLE_EVALUACION>()
                .Property(e => e.COD_ROL)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_DETALLE_EVALUACION>()
                .Property(e => e.PONDERACION)
                .HasPrecision(2, 2);

            modelBuilder.Entity<EVA_DETALLE_EVALUACION>()
                .HasMany(e => e.EVA_RESPUESTA_CUESTIONARIO)
                .WithRequired(e => e.EVA_DETALLE_EVALUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVA_EVALUACION>()
                .Property(e => e.COD_EVALUACION)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_EVALUACION>()
                .Property(e => e.COD_CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_EVALUACION>()
                .Property(e => e.RESULTADO)
                .HasPrecision(2, 2);

            modelBuilder.Entity<EVA_EVALUACION>()
                .HasMany(e => e.EVA_DETALLE_EVALUACION)
                .WithRequired(e => e.EVA_EVALUACION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVA_PREGUNTA>()
                .Property(e => e.COD_CUESTIONARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_PREGUNTA>()
                .Property(e => e.ENUNCIADO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_PREGUNTA>()
                .HasMany(e => e.EVA_RESPUESTA_PREGUNTA)
                .WithRequired(e => e.EVA_PREGUNTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVA_RESPUESTA_CUESTIONARIO>()
                .Property(e => e.COD_CURSO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_RESPUESTA_CUESTIONARIO>()
                .Property(e => e.COD_CUESTIONARIO)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_RESPUESTA_CUESTIONARIO>()
                .Property(e => e.COD_PERSONA)
                .IsUnicode(false);

            modelBuilder.Entity<EVA_RESPUESTA_CUESTIONARIO>()
                .Property(e => e.CALIFICACION_PROMEDIO)
                .HasPrecision(2, 2);

            modelBuilder.Entity<EVA_RESPUESTA_PREGUNTA>()
                .Property(e => e.COD_PERSONA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AREA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AREA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AULA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AULA>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AULA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_AULA>()
                .HasMany(e => e.INS_HORARIO)
                .WithRequired(e => e.INS_AULA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_CALIFICACION>()
                .Property(e => e.VALOR_CALIFICACION)
                .HasPrecision(6, 2);

            modelBuilder.Entity<INS_CLASE>()
                .Property(e => e.COD_CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLASE>()
                .Property(e => e.COD_DOCENTE)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLASE>()
                .Property(e => e.MODALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLASE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLASE>()
                .HasMany(e => e.EVA_EVALUACION)
                .WithOptional(e => e.INS_CLASE)
                .HasForeignKey(e => new { e.COD_CLASE, e.INS_COD_CURSO });

            modelBuilder.Entity<INS_CLASE>()
                .HasMany(e => e.INS_HORARIO)
                .WithOptional(e => e.INS_CLASE)
                .HasForeignKey(e => new { e.COD_CLASE, e.COD_CURSO });

            modelBuilder.Entity<INS_CLASE>()
                .HasMany(e => e.INS_MATRICULA)
                .WithOptional(e => e.INS_CLASE)
                .HasForeignKey(e => new { e.COD_CLASE, e.COD_CURSO });

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.NUM_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.CORREO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CLIENTE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CURSO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CURSO>()
                .Property(e => e.COSTO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<INS_CURSO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_CURSO>()
                .HasMany(e => e.INS_CLASE)
                .WithRequired(e => e.INS_CURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_CURSO>()
                .HasMany(e => e.INS_PROGRAMA_CURSO)
                .WithRequired(e => e.INS_CURSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_DETALLE_FACTURA>()
                .Property(e => e.COD_FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_DETALLE_FACTURA>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<INS_DETALLE_FACTURA>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(6, 4);

            modelBuilder.Entity<INS_DETALLE_FACTURA>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(6, 4);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.COD_FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(6, 2);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.IVA)
                .HasPrecision(6, 2);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.DESCUENTO)
                .HasPrecision(6, 2);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.TOTAL)
                .HasPrecision(6, 2);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FACTURA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FACTURA>()
                .HasMany(e => e.INS_FACTURA_FORMAPAGO)
                .WithRequired(e => e.INS_FACTURA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_FACTURA_FORMAPAGO>()
                .Property(e => e.COD_FACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FACTURA_FORMAPAGO>()
                .Property(e => e.FORMA_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FACTURA_FORMAPAGO>()
                .Property(e => e.VALOR)
                .HasPrecision(6, 4);

            modelBuilder.Entity<INS_FRANJA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_FRANJA>()
                .HasMany(e => e.INS_HORARIO)
                .WithRequired(e => e.INS_FRANJA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_HORARIO>()
                .Property(e => e.COD_CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<INS_HORARIO>()
                .Property(e => e.DIA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_HORARIO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_MATRICULA>()
                .Property(e => e.COD_CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<INS_MATRICULA>()
                .Property(e => e.COD_ALUMNO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_MATRICULA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.COD_PERSONA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.GENERO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA>()
                .HasMany(e => e.EVA_RESPUESTA_CUESTIONARIO)
                .WithRequired(e => e.INS_PERSONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_PERSONA>()
                .HasMany(e => e.INS_CLASE)
                .WithOptional(e => e.INS_PERSONA)
                .HasForeignKey(e => e.COD_DOCENTE);

            modelBuilder.Entity<INS_PERSONA>()
                .HasMany(e => e.INS_MATRICULA)
                .WithOptional(e => e.INS_PERSONA)
                .HasForeignKey(e => e.COD_ALUMNO);

            modelBuilder.Entity<INS_PERSONA>()
                .HasMany(e => e.INS_PERSONA_USUARIO)
                .WithRequired(e => e.INS_PERSONA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_PERSONA_USUARIO>()
                .Property(e => e.COD_PERSONA)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA_USUARIO>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PERSONA_USUARIO>()
                .Property(e => e.COD_ROL)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PREREQUISITO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PROGRAMA>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_PROGRAMA>()
                .HasMany(e => e.INS_PROGRAMA_CURSO)
                .WithRequired(e => e.INS_PROGRAMA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_PROGRAMA_CURSO>()
                .HasMany(e => e.INS_PREREQUISITO)
                .WithRequired(e => e.INS_PROGRAMA_CURSO)
                .HasForeignKey(e => new { e.COD_CURSO, e.COD_PROGRAMA })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_PROGRAMA_CURSO>()
                .HasMany(e => e.INS_PREREQUISITO1)
                .WithRequired(e => e.INS_PROGRAMA_CURSO1)
                .HasForeignKey(e => new { e.COD_CURSO_PREV, e.COD_PROGRAMA_PREV })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INS_TEMA>()
                .Property(e => e.COD_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_TEMA>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<INS_TEMA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<INS_TEMA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_FUNCIONALIDAD>()
                .Property(e => e.COD_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_FUNCIONALIDAD>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_FUNCIONALIDAD>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_FUNCIONALIDAD>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_FUNCIONALIDAD>()
                .HasMany(e => e.SEG_PERFIL_FUNCIONALIDAD)
                .WithRequired(e => e.SEG_FUNCIONALIDAD)
                .HasForeignKey(e => new { e.COD_MODULO, e.SEC_FUNCIONALIDAD })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEG_MODULO>()
                .Property(e => e.COD_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_MODULO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_MODULO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_MODULO>()
                .HasMany(e => e.SEG_FUNCIONALIDAD)
                .WithRequired(e => e.SEG_MODULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEG_PERFIL>()
                .Property(e => e.COD_PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_PERFIL>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_PERFIL>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_PERFIL>()
                .HasMany(e => e.SEG_PERFIL_FUNCIONALIDAD)
                .WithRequired(e => e.SEG_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEG_PERFIL_FUNCIONALIDAD>()
                .Property(e => e.COD_PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_PERFIL_FUNCIONALIDAD>()
                .Property(e => e.COD_MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_PERFIL_FUNCIONALIDAD>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.TIPO_ACCESO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.FUNCIONALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.RESULTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_REGISTRO_ACCESO>()
                .Property(e => e.FECHA)
                .IsFixedLength();

            modelBuilder.Entity<SEG_ROL>()
                .Property(e => e.COD_ROL)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_ROL>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_ROL>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_ROL>()
                .HasMany(e => e.INS_PERSONA_USUARIO)
                .WithRequired(e => e.SEG_ROL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.COD_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.COD_PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.CORREO_ELECTRONICO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_USUARIO>()
                .Property(e => e.INTENTOS_ERRONEOS)
                .HasPrecision(2, 0);

            modelBuilder.Entity<SEG_USUARIO>()
                .HasMany(e => e.INS_PERSONA_USUARIO)
                .WithRequired(e => e.SEG_USUARIO)
                .WillCascadeOnDelete(false);
        }
    }
}
