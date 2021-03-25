using jeuxdontonestlehero.Core.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {

        public ActionResult Index(int id)
        {
            this.ViewBag.MonSuperId = id;
            return this.View(); 
        }

        public ActionResult Create()
        {
            return this.View(); 
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }

    }
}
