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
        private EscuelaContext _context;

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var escuela = _context.Escuelas.FirstOrDefault();
            ViewBag.CosaDinamica = "La monja";
            return View(escuela);

        }

       
    }
}
