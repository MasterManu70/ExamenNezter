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
    public class LoginController : Controller
    {
        LoginData data = new LoginData();
        UsuariosData dataU = new UsuariosData();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verify()
        {
            string Usuario = Request.Form["Usuario"].ToString();
            string Contrasena = Request.Form["Contrasena"].ToString();
            if (data.Verify(Usuario, Contrasena))
            {
                HttpContext.Session.SetString("User","User");
                //IEnumerable<UsuariosModel> lista = dataU.Consultar();
                //return View("~/Views/Usuarios/Index.cshtml",lista);
                //Response.Redirect("Usuarios/");
                return RedirectToAction("Index", "Usuarios");
            }
            return View("Index");
        }
    }
}
