using ParcialMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcialMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Deportista()
        {
            Datos objDeportista = new Datos();
            string oper = Request.Params["btnOpe"];
            objDeportista.edad = int;
            objDeportista.estatura = double.Parse(Request.Form["txtEstatura"].ToString());
            objDeportista.peso = double.Parse(Request.Form["txtPeso"].ToString());
            if (oper=="Deportista")
            {
                if (objDeportista.edad<=18 && objDeportista.estatura>180 && objDeportista.peso <= 80)
                {
                    objDeportista.respuesta = "ACEPTADO";
                }
                else
                {
                    objDeportista.respuesta = "RECHAZADO";
                }
            }
            return View("Deportista", objDeportista);
        }
        public ActionResult Estudiante()
        {
            Datos objEstudiante = new Datos();
            string oper = Request.Params["btnOpe"];
            
            return View("Estudiante", objEstudiante);
        }
        public ActionResult Numeros()
        {
            Datos objNumeros = new Datos();
            string oper = Request.Params["btnOpe"];

            return View("Numeros", objNumeros);
        }
        public ActionResult Compra()
        {
            Datos objCompra = new Datos();
            string oper = Request.Params["btnOpe"];

            return View("Compra", objCompra);
        }
    }
}