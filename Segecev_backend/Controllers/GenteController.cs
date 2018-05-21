using BDD_Proyecto;
using Segecev_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Segecev_backend.Controllers
{
    public class GenteController : Controller
    {
        // GET: Gente
        public ActionResult listar()
        {
            /* Repositorio _repo = new Repositorio();

             List<INS_PERSONA> list = _repo.GetPersonas();
             */

            ContextProyecto _cotexto = new ContextProyecto();
            List<INS_PERSONA> list = _cotexto.INS_PERSONA.ToList();

            var result = list.Select(x => new PersonasView
            {
                COD_PERSONA = x.COD_PERSONA,
                NOMBRE = x.NOMBRE,
                APELLIDO = x.APELLIDO,
                DIRECCION = x.DIRECCION,
                TELEFONO = x.TELEFONO,
                FEC_NAC = x.FEC_NAC.ToString(),
                TIPO = x.TIPO,
                GENERO = x.GENERO,
                ESTADO = x.ESTADO
            });

            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
            //return View();
        }
    }
}