using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Queries
{
    class OffreQuery
    {
        private readonly Context _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreQuery(Context contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Offre> GetAll()
        {
            return _contexte.Offres;
        }

        /// <summary>
        /// Récupérer un produit par son ID
        /// </summary>
        /// <param name="id">Identifiant du produit à récupérer</param>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Offre> GetByID(int id)
        {
            return _contexte.Offres.Include("Statut").Where(o => o.OffreId == id);
        }

        public IQueryable<Offre> GetOffreByName(string name)
        {
            return _contexte.Offres.Where(o => o.OffreIntitule.ToLower().Contains(name));
        }

    }
}
