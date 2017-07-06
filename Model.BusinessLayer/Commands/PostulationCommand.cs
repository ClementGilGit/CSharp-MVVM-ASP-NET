using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Commands
{
    class PostulationCommand
    {
        private readonly Context _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public PostulationCommand(Context contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le produit en base à partir du contexte
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Ajouter(Postulation p)
        {
            try
            {
                _contexte.Postulations.Add(p);
                return _contexte.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
