using System;
using System.Collections.Generic;

namespace BDD_Proyecto
{
    public interface IRepositorio
    {
        List<INS_PERSONA> GetPersonas();
        Respuesta GuardarModificarUsuario(SEG_USUARIO usr);
        List<SEG_USUARIO> ListarUsuarios();
        Respuesta Login(SEG_USUARIO usr);        
    }
}