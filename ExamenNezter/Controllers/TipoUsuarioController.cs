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
    public class TipoUsuarioController : Controller
    {
        TipoUsuarioData data = new TipoUsuarioData();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            IEnumerable<TipoUsuarioModel> lista = data.Consultar();
            return View(lista);
        }

        public IActionResult Guardar(TipoUsuarioModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Guardar", modelo);
        }

        public IActionResult Nuevo(TipoUsuarioModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Guardar(modelo);
            IEnumerable<TipoUsuarioModel> lista = data.Consultar();
            return View("Index", lista);
        }

        public IActionResult Eliminar(TipoUsuarioModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Eliminar", modelo);
        }

        public IActionResult Borrar(TipoUsuarioModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Eliminar(modelo);
            IEnumerable<TipoUsuarioModel> lista = data.Consultar();
            return View("Index", lista);
        }
    }
}
