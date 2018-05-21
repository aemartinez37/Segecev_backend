using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Segecev_backend.Models
{
    public class PersonasView
    {
        public string COD_PERSONA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string FEC_NAC { get; set; }
        public string TIPO { get; set; }
        public string GENERO { get; set; }
        public string ESTADO { get; set; }
    }
}