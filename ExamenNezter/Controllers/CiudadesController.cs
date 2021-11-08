using ExamenNezter.Datos;
using ExamenNezter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Controllers
{
    public class CiudadesController : Controller
    {
        CiudadesData data = new CiudadesData();

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            IEnumerable<CiudadesModel> lista = data.Consultar();
            return View(lista);
        }

        public IActionResult Guardar(CiudadesModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            ExamenNezter.Datos.EstadosData dataEstado = new ExamenNezter.Datos.EstadosData();
            IEnumerable<ExamenNezter.Models.EstadosModel> modeloEstado = dataEstado.Consultar();

            ViewBag.mySelect = new SelectList(modeloEstado, "Id", "Estado");
            return View("Guardar", modelo);
        }

        public IActionResult Nuevo(CiudadesModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Guardar(modelo);
            IEnumerable<CiudadesModel> lista = data.Consultar();
            return View("Index", lista);
        }

        public IActionResult Select(string mySelect, CiudadesModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            modelo.Id_estado = int.Parse(mySelect);
            this.Nuevo(modelo);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(CiudadesModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Eliminar", modelo);
        }

        public IActionResult Borrar(CiudadesModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Eliminar(modelo);
            IEnumerable<CiudadesModel> lista = data.Consultar();
            return View("Index", lista);
        }
    }
}
