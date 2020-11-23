using IntroduccionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionMVC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            Datos objModelo = new Datos();
            objModelo.variableA = 3;
            objModelo.variableB = 5;
            objModelo.resultado = objModelo.variableA + objModelo.variableB;
            ViewData["Resultado"] = objModelo.resultado;
            return View();
        }

        public ActionResult Resta()
        {
            Datos objModelo = new Datos();
            
            objModelo.variableA = double.Parse(Request.Form["txtValor1"].ToString());
            objModelo.variableB = double.Parse(Request.Form["txtValor2"].ToString());
            objModelo.resultado = objModelo.variableA - objModelo.variableB;
            return View("Resta",objModelo);
        }
        public ActionResult Opera()
        {
            Datos objModelo = new Datos();
            string oper = Request.Params["btnOpe"];
            objModelo.variableA = double.Parse(Request.Form["txtValor1"].ToString());
            objModelo.variableB = double.Parse(Request.Form["txtValor2"].ToString());
            if (oper=="Sumar")
            {
                objModelo.resultado = objModelo.variableA + objModelo.variableB;
            }
            if (oper=="Restar")
            {
                objModelo.resultado = objModelo.variableA - objModelo.variableB;
            }
            if (oper=="Multiplicar")
            {
                objModelo.resultado = objModelo.variableA * objModelo.variableB;
            }
            if (oper=="Dividir")
            {
                objModelo.resultado = objModelo.variableA / objModelo.variableB;
            }
            return View("Opera", objModelo);
        }
    }
}