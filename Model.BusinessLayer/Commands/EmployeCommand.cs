using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Commands
{
    class EmployeCommand
    {
        private readonly Context _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public EmployeCommand(Context contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le produit en base à partir du contexte
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Ajouter(Employe e)
        {
            _contexte.Employes.Add(e);
            return _contexte.SaveChanges();
        }


        /// <summary>
        /// Supprimer un produit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="produitID">Identifiant du produit à supprimer</param>
        public void Supprimer(int EmpId)
        {
            Employe delEmp = _contexte.Employes.Where(e => e.EmpId == EmpId).FirstOrDefault();
            if (delEmp != null)
            {
                _contexte.Employes.Remove(delEmp);
            }
            _contexte.SaveChanges();
        }

    }
}
