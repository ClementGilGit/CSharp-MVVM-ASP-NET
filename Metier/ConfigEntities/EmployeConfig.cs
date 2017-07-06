using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Metier.ConfigEntities
{
    public class EmployeConfig : EntityTypeConfiguration<Employe>
    {

        public EmployeConfig()
        {
            ToTable("Employe");
            HasKey(em => em.EmpId);

            Property(em => em.EmpId).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(em => em.EmpNom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(50);
            Property(em => em.EmpPrenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(50);
            Property(em => em.EmpDateNaissance).HasColumnName("EMP_DATENAISSANCE").IsRequired();
            Property(em => em.EmpAnciennete).HasColumnName("EMP_ANCIENNETE").IsRequired();
            Property(em => em.EmpBiographie).HasColumnName("EMP_BIOGRAPHIE").IsRequired().HasMaxLength(200);
        }
    }
}
