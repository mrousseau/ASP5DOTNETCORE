using jeudontonestleheros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuxdontonestlehero.Core.Data;

namespace jeudontonestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        
        public IActionResult Index()
        {
            this.ViewBag.Montitre = "Aventure";

            List <Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "Ma première aventure"
            });

            maList.Add(new Aventure()
            {
                Id = 2,
                Titre = "Ma Seconde aventure"
            });

            return View(maList);
        }

    }
}
