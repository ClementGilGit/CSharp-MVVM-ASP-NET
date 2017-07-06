using Metier.Context;
using Metier.Entities;
using Model.BusinessLayer.Commands;
using Model.BusinessLayer.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer
{
    public class BusinessManager
    {
        /// <summary>
        /// BusinessManager de la BusinessLayer
        /// Cette classe est un singleton est instancie un contexte EF dans son constructeur
        /// </summary>
            private readonly Context context;
            private static BusinessManager _businessManager = null;

            /// <summary>
            /// Constructeur, initialisation du contexte EF
            /// </summary>
            private BusinessManager()
            {
                context = new Context();
            }

            /// <summary>
            /// Récupérer l'instance du pattern Singleton
            /// </summary>
            public static BusinessManager Instance
            {
                get
                {
                    if (_businessManager == null)
                        _businessManager = new BusinessManager();
                    return _businessManager;
                }
            }

            #region Employe

            /// <summary>
            /// Récupérer une liste de produit en base
            /// </summary>
            /// <returns>Liste de Produit</returns>
            public List<Employe> GetAllEmploye()
            {
                EmployeQuery eq = new EmployeQuery(context);
                return eq.GetAll().ToList();
            }


        public int AjouterEmploye(Employe e)
            {
                // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
                EmployeCommand ec = new EmployeCommand(context);
                return ec.Ajouter(e);
            }

        #endregion

        #region Offre

        public List<Offre> GetAllOffre()
        {
            OffreQuery eq = new OffreQuery(context);
            return eq.GetAll().ToList();
        }

        public int Postuler(Postulation p)
        {
            PostulationCommand pc = new PostulationCommand(context);
            return pc.Ajouter(p);
        }

        public List<Offre> GetOffreById(int id)
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.GetByID(id).ToList();
        }


        public List<Offre> GetOffreByName(string name)
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.GetOffreByName(name).ToList();
        }

        public void Modifier(int id, String intitule, int salaire, String description, String reponsable)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Modifier(id,intitule, salaire, description, reponsable);
        }

        #endregion


        #region Postulation

        public List<Postulation> GetAllPostulation()
        {
            PostulationQuery pq = new PostulationQuery(context);
            return pq.GetAll().ToList();
        }

        public List<Postulation> GetPostulationById(int id)
        {
            PostulationQuery pq = new PostulationQuery(context);
            return pq.GetBySingleID(id).ToList();
        }

        public List<Postulation> GetByEmpId(int id)
        {
            PostulationQuery pq = new PostulationQuery(context);
            return pq.GetByEmpID(id).ToList();
        }

        #endregion

        #region Statut
        public List<Statut> GetAllStatut()
        {
            StatutQuery sq = new StatutQuery(context);
            return sq.GetAll().ToList();
        }

        public List<Statut> GetStatutById(int id)
        {
            StatutQuery sq = new StatutQuery(context);
            return sq.GetBySingleID(id).ToList();
        }
        #endregion
    }

}
