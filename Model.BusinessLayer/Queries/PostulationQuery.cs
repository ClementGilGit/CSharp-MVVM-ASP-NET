using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Queries
{
    class PostulationQuery
    {
        private readonly Context _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public PostulationQuery(Context contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Postulation> GetAll()
        {
            return _contexte.Postulations.Include("Employe");
        }

        /// <summary>
        /// Récupérer un produit par son ID
        /// </summary>
        /// <param name="id">Identifiant du produit à récupérer</param>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Postulation> GetByID(int id, int id2)
        {
            return _contexte.Postulations.Where(p => p.EmpId == id && p.OffreId == id2);
        }

        public IQueryable<Postulation> GetByEmpID(int id)
        {
            return _contexte.Postulations.Include("Employe").Include("Offre").Where(p => p.EmpId == id);
        }


        public IQueryable<Postulation> GetBySingleID(int id)
        {
            return _contexte.Postulations.Include("Employe").Include("Offre").Where(p => p.OffreId == id);
        }


    }
}
