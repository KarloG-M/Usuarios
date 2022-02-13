 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usuarios.Controllers
{
    [Route("/Nombre")]
    public class UsuariosController : Controller
    {
        [Route("/Nombre/Alex")]
        //[HttpGet]
        //[Route("/Usuarios/Alex")] //Nueva ruta para esta pagiona/ no se ejecuta hasta que se escriba en el navegador de 5 a 9
        public IActionResult Index(int id )
        {
            //ViewData["iD"] = id;
            return View();
        }
    }
}
