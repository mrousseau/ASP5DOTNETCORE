using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        
        public IActionResult Index()
        {
            this.ViewBag.Montitre = "Aventure"; 

            return View();
        }

    }
}
