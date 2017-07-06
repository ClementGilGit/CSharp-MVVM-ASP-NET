using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class OffreController : Controller
    {
        // GET: Offre
        public ActionResult OffreHome()
        {

            List<Offre> offres = BusinessManager.Instance.GetAllOffre();
            //ViewBag.Offres = offres;
            return View(offres);
        }


        public ActionResult Rechercher()
        {
            String recherche = Request["recherche"];
            List<Offre> offres = BusinessManager.Instance.GetOffreByName(recherche);
            return View("OffreHome",offres);
        }
    }
}