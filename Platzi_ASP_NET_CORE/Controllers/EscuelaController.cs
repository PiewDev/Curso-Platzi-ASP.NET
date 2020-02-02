using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Platzi_ASP_NET_CORE.Models;

namespace Platzi_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela()
            {
                AñoDeCreación = 2005,
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Platzi",
                Ciudad = "Rafaela",
                Pais = "Argentina",
                Dirección = "Los Colonos 8100",
                TipoEscuela = TiposEscuela.Secundaria

            };

            ViewBag.CosaDinamica = "La monja";
            return View(escuela);

        }
    }
}
