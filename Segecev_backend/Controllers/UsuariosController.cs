using BDD_Proyecto;
using Segecev_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Segecev_backend.Controllers
{
    public class UsuariosController : Controller
    {
        IRepositorio _repo;
        // GET: Usuarios
        public UsuariosController()
        {
            _repo = new Repositorio();
        }
        public ActionResult listar()
        {
            List<SEG_USUARIO> list = _repo.ListarUsuarios();
            
            var result = list.Select(x => new UsuariosView
            {
                COD_USUARIO = x.COD_USUARIO,
                COD_PERFIL = x.COD_PERFIL,
                CORREO_ELECTRONICO = x.CORREO_ELECTRONICO,
                NOMBRE = x.NOMBRE,
                CLAVE = x.CLAVE,
                ESTADO = x.ESTADO,
                FECHA_CREACION = x.FECHA_CREACION.ToString(),
                INTENTOS_ERRONEOS=(int)x.INTENTOS_ERRONEOS,
                FECHA_ULTIMO_ACCESO=x.FECHA_ULTIMO_ACCESO.ToString()
        
            });

            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GuardarModificar(UsuariosView usr)
        {
            Seguridad seg = new Seguridad();
            SEG_USUARIO nuevoUsuario = new SEG_USUARIO()
            {
                COD_USUARIO = usr.COD_USUARIO,
                COD_PERFIL = usr.COD_PERFIL,
                CORREO_ELECTRONICO = usr.CORREO_ELECTRONICO,
                NOMBRE = usr.NOMBRE,
                CLAVE = seg.CalculateMD5Hash(usr.CLAVE),
                ESTADO = usr.ESTADO,
                FECHA_CREACION = Convert.ToDateTime(usr.FECHA_CREACION),
                INTENTOS_ERRONEOS = (decimal)usr.INTENTOS_ERRONEOS,
                FECHA_ULTIMO_ACCESO = Convert.ToDateTime(usr.FECHA_ULTIMO_ACCESO)
            };
            var result =_repo.GuardarModificarUsuario(nuevoUsuario);
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult InicioSesion(UsuariosView usr)
        {
            Seguridad seg = new Seguridad();
            SEG_USUARIO UsuarioLogin = new SEG_USUARIO()
            {
                COD_USUARIO = usr.COD_USUARIO,
                COD_PERFIL = null,
                CORREO_ELECTRONICO = null,
                NOMBRE = usr.IP,
                CLAVE = usr.CLAVE,
                ESTADO = null,
                FECHA_CREACION = DateTime.Now,
                INTENTOS_ERRONEOS = (decimal)0,
                FECHA_ULTIMO_ACCESO = DateTime.Now
            };
            var result = _repo.Login(UsuarioLogin);
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }

    }
}