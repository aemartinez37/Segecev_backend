using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Segecev_backend.Models
{
    public class UsuariosView
    {
        public string COD_USUARIO {get;set;}
        public string COD_PERFIL {get;set;}
        public string CORREO_ELECTRONICO {get;set;}
        public string NOMBRE {get;set;}
        public string CLAVE {get;set;}
        public string ESTADO {get;set;}
        public string FECHA_CREACION {get;set;}
        public int INTENTOS_ERRONEOS {get;set;}
        public string FECHA_ULTIMO_ACCESO {get;set;}
        public string IP { get; set; }
    }
}