using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFerreteria.Models;

namespace WebFerreteria.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
          ViewData["fecha"] = DateTime.Now.ToString();
         
            Cliente obj = new Cliente();
            obj.Codigo = "C001";
            obj.Nombre = "DEIVI";
            obj.Edad = 19;
            return View("Index", obj);
        }
    }
}