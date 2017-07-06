using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.BusinessLayer;
using System.Collections.Generic;
using Metier.Entities;

namespace Test
{
    [TestClass]
    public class BusinessManagerTest
    {


        #region OffreTests

        [TestMethod]
        public void GetAllOffreTest()
        {
            List<Offre> lesOffres = BusinessManager.Instance.GetAllOffre();
            Assert.IsNotNull(lesOffres);
        }

        #endregion

        #region PostulationTests

        [TestMethod]
        public void GetAllPostulationTest()
        {
            List<Postulation> lesPostulations = BusinessManager.Instance.GetAllPostulation();
            Assert.IsNotNull(lesPostulations);
        }

        #endregion

    }
}
