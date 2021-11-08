using ExamenNezter.Datos;
using ExamenNezter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Controllers
{
    public class EstadosController : Controller
    {
        EstadosData data = new EstadosData();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            IEnumerable<EstadosModel> lista = data.Consultar();
            return View(lista);
        }

        public IActionResult Guardar(EstadosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Guardar", modelo);
        }

        public IActionResult Nuevo(EstadosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Guardar(modelo);
            IEnumerable<EstadosModel> lista = data.Consultar();
            return View("Index",lista);
        }

        public IActionResult Eliminar(EstadosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Eliminar", modelo);
        }

        public IActionResult Borrar(EstadosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Eliminar(modelo);
            IEnumerable<EstadosModel> lista = data.Consultar();
            return View("Index",lista);
        }
    }
}
