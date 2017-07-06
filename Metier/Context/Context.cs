using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using Metier.Entities;

namespace Metier.Context
{
    public class Context : DbContext
    {
        public Context() : base("name=Jalon1Context")
        {
           // Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Formation> CliFormationsents { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Statut> Statuts { get; set; }

    }
}
