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
        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe() { id = 1, Numero = 10 , Titre = "Min titre" },
            new Paragraphe() { id = 2, Numero = 20 , Titre = "Min titre2" },
            new Paragraphe() { id = 3, Numero = 30 , Titre = "Min titre3" },
        };


        public ActionResult Index()
        {
            //Paragraphe paragraphe = new Paragraphe(); 
            //paragraphe.id = 1;
            //paragraphe.Numero = 11;
            //paragraphe.Titre = "The Question";
            //paragraphe.Description = "description de la question";


            //this.ViewBag.Paragraphe = paragraphe; 
            return this.View();
        }


        //public ActionResult Index(int id)
        //{
        //    this.ViewBag.MonSuperId = id;
        //    return this.View(); 
        //}

        public ActionResult Create()
        {
            return this.View(); 
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }


        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _maList.First(item => item.id == id);

            return this.View(paragraphe);
        }

        [HttpPost ]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return this.View();
        }



    }
}
