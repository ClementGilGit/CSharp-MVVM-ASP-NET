using Metier.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.ConfigEntities
{
    public class ExperienceConfig : EntityTypeConfiguration<Experience>
    {

        public ExperienceConfig()
        {
            ToTable("Experience");
            HasKey(ex => ex.ExpId);

            Property(ex => ex.ExpId).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(ex => ex.EmpId).HasColumnName("EMP_ID").IsRequired();         
            Property(ex => ex.EmpIntitule).HasColumnName("EXP_INTITULE").IsRequired().HasMaxLength(50);
            Property(ex => ex.ExpDate).HasColumnName("EXP_DATE").IsRequired();

            HasRequired(em => em.Employe).WithMany(em => em.Experiences).HasForeignKey(ex => ex.EmpId);
        }
    }
}
