using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerProjetos.Controllers
{
    [Login]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
