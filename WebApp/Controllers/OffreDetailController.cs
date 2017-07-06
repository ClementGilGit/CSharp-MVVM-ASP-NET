using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class OffreDetailController : Controller
    {
        // GET: OffreDetail
        public ActionResult AfficherDetail(int id)
        {

            List<Offre> offreDetails = BusinessManager.Instance.GetOffreById(id);
            List<Postulation> postulations = BusinessManager.Instance.GetPostulationById(id);
            //List<Employe> employes = BusinessManager.Instance.
            //ViewBag.Offres = offres;
            return View("OffreDetail",offreDetails);
        }

        public ActionResult Postuler()
        {
            Postulation p = new Postulation();
            p.EmpId = int.Parse(Request["EmployeId"]);
            p.PosStatut = "1";
            p.OffreId = int.Parse(Request["OffreId"]);
            p.PosDate = DateTime.Now;
            BusinessManager.Instance.Postuler(p);
            return RedirectPermanent("/Offre/OffreHome");
        }
    }
}