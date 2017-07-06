using Metier.Context;
using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Console.Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestEFAvecFluent();
            //TestAjout();
        }

        public static void TestAjout()
        {
            BusinessManager bm = BusinessManager.Instance;
            Employe e = new Employe();
            e.EmpNom = "Malgou";
            e.EmpPrenom = "Re";
            e.EmpBiographie = "remi le peg";
            e.EmpDateNaissance = DateTime.Today;
            e.EmpAnciennete = 1;

            try
            {
                bm.AjouterEmploye(e);
            }
            catch (Exception ex)
            {
                throw;
            }

            bm.GetAllEmploye();
        }


        public static void TestEFAvecFluent()
        {
            // test du contexte avec api fluent
            Context contextFluent = new Context();
            

            //// ajout d'un nouveau client avec un compte
            //List<Employe> comptes = new List<Employe>();
            //comptes.Add(new Employe { EmpNom = "Doe", EmpPrenom = "John" , EmpDateNaissance= new DateTime(2000, 12, 5), EmpAnciennete=1,EmpBiographie="biographie"});
            //contextFluent.Employes.Add(new Employe { EmpNom = "Malgou", EmpPrenom = "Re", EmpDateNaissance = new DateTime(1000,12,5), EmpAnciennete = 0, EmpBiographie = "biographie" });
            //contextFluent.SaveChanges();

            //// lecture des clients
            ////List<Employe> mesAutresEmployes = contextFluent.Employes.Include(e => e.EmpNom).ToList();
            //Console.WriteLine("Liste de mes clients avec Fluent : ");
            //foreach (ModeleFluent.Client c in mesAutresClients)
            //{
            //    Console.WriteLine("Client n°{0} : {1}", c.Id, c.Nom);
            //    foreach (ModeleFluent.CompteClient cc in c.Comptes)
            //    {
            //        Console.WriteLine("|__ Compte n°{0}", cc.NumeroCompte);
            //    }
            //}
            //Console.WriteLine("...Fin...");
        }
    }
}
