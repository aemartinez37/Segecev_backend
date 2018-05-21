using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BDD_Proyecto
{
    public class Repositorio : IRepositorio
    {
        private ContextProyecto _context;

        public Repositorio()
        {
            _context = new ContextProyecto();
        }

        public List<INS_PERSONA> GetPersonas()
        {
            List<INS_PERSONA> listaPersonas = _context.INS_PERSONA.ToList();
            return listaPersonas;
        }

        public List<SEG_USUARIO> ListarUsuarios()
        {
            List<SEG_USUARIO> listaUsuarios = _context.SEG_USUARIO.ToList();
            return listaUsuarios;
        }

        public Respuesta GuardarModificarUsuario(SEG_USUARIO usr)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                _context.SEG_USUARIO.AddOrUpdate(usr);
                _context.SaveChanges();

                resultado.Success = true;
                resultado.Id = usr.COD_USUARIO;
            }
            catch(Exception e)
            {
                resultado.Success = false;
                resultado.Mensaje = e.Message;
            }

            return resultado;
        }

        public Respuesta Login(SEG_USUARIO usr)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                SEG_USUARIO user= _context.SEG_USUARIO.Find(usr.COD_USUARIO);

                if (user == null)
                {
                    resultado.Success = false;
                    resultado.Mensaje = "No Existe Usuario!";
                }
                else
                {
                    if (usr.CLAVE.CompareTo(user.CLAVE) != 0)
                    {
                        if (user.INTENTOS_ERRONEOS < 3)
                        {
                            user.INTENTOS_ERRONEOS += 1;
                            this.GuardarModificarUsuario(user);
                            resultado.Success = false;
                            resultado.Mensaje = "Clave Incorrecta!";
                        }
                        else
                        {
                            user.ESTADO="SUS";
                            this.GuardarModificarUsuario(user);
                            resultado.Success = false;
                            resultado.Mensaje = "Cuenta Suspendida, Intentelo mas Tarde!";
                        }
                    }
                    else
                    {
                        if (user.INTENTOS_ERRONEOS >= 3 || user.ESTADO.CompareTo("ACT") != 0)
                        {
                            resultado.Success = false;
                            resultado.Mensaje = "Su Cuenta de Encuentra Suspendida!";
                        }
                        else
                        {
                            //Login Correcto
                            user.INTENTOS_ERRONEOS = (decimal)0;
                            user.FECHA_ULTIMO_ACCESO = DateTime.Now;
                            this.GuardarModificarUsuario(user);

                            //Log de Ingreso

                            

                            resultado.Success = true;
                            resultado.Id = user.COD_USUARIO;
                            resultado.Mensaje = user.NOMBRE+","+user.COD_PERFIL + "," + user.CORREO_ELECTRONICO;
                        }
                    }

                }
                
            }
            catch (Exception e)
            {
                resultado.Success = false;
                resultado.Mensaje = e.Message;
            }

            return resultado;
        }

        

    }
}