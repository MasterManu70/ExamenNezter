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
    public class UsuariosController : Controller
    {
        UsuariosData data = new UsuariosData();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            IEnumerable<UsuariosModel> lista = data.Consultar();
            return View(lista);
        }

        public IActionResult Guardar(UsuariosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            ExamenNezter.Datos.CiudadesData dataCiudad = new ExamenNezter.Datos.CiudadesData();
            IEnumerable<ExamenNezter.Models.CiudadesModel> modeloCiudad = dataCiudad.Consultar();

            ViewBag.mySelectC = new SelectList(modeloCiudad, "Id", "Ciudad");

            ExamenNezter.Datos.TipoUsuarioData dataTipoUsuario = new ExamenNezter.Datos.TipoUsuarioData();
            IEnumerable<ExamenNezter.Models.TipoUsuarioModel> modeloTipoUsuario = dataTipoUsuario.Consultar();

            ViewBag.mySelectTU = new SelectList(modeloTipoUsuario, "Id", "Tipo_usuario");
            return View("Guardar", modelo);
        }

        public IActionResult Nuevo(UsuariosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Guardar(modelo);
            IEnumerable<UsuariosModel> lista = data.Consultar();
            return View("Index", lista);
        }

        public IActionResult Select(string mySelectC,string mySelectTU, UsuariosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            modelo.Id_ciudad = int.Parse(mySelectC);
            modelo.Id_tipo_usuario = int.Parse(mySelectTU);
            this.Nuevo(modelo);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(UsuariosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            return View("Eliminar", modelo);
        }

        public IActionResult Borrar(UsuariosModel modelo)
        {
            if (HttpContext.Session.GetString("User") != "User")
                return RedirectToAction("Index", "Login");

            data.Eliminar(modelo);
            IEnumerable<UsuariosModel> lista = data.Consultar();
            return View("Index", lista);
        }
    }
}
