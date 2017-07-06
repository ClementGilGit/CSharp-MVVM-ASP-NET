using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PostulationController : Controller
    {
        // GET: Postulation
        public ActionResult PostulationList()
        {
            int id = 1;
            List<Postulation> postulations = BusinessManager.Instance.GetByEmpId(id);
            //List<Postulation> postulations = BusinessManager.Instance.GetAllPostulation();
            return View(postulations);
        }

    }
}