using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Commands
{
    class OffreCommand
    {
        private readonly Context _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public OffreCommand(Context contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le produit en base à partir du contexte
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Ajouter(Offre o)
        {
            _contexte.Offres.Add(o);
            return _contexte.SaveChanges();
        }


        /// <summary>
        /// Supprimer un produit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="OffreId">Identifiant du produit à supprimer</param>
        public void Supprimer(int OffreId)
        {
            Offre deloff = _contexte.Offres.Where(o => o.OffreId == OffreId).FirstOrDefault();
            if (deloff != null)
            {
                _contexte.Offres.Remove(deloff);
            }
            _contexte.SaveChanges();
        }

        public void Modifier(int OffreId, String intitule,int salaire,String description,String responsable)
        {
            Offre modoff = _contexte.Offres.Where(o => o.OffreId == OffreId).FirstOrDefault();
            if (modoff != null)
            {
                //_contexte.Entry(modoff).CurrentValues.SetValues(modoff);
                //_contexte.SaveChanges();
                modoff.OffreIntitule = intitule;
                modoff.OffreSalaire = salaire;
                modoff.OffreDescription = description;
                modoff.OffreResponsable = responsable;
                _contexte.SaveChanges();
            }
        }
    }
}
