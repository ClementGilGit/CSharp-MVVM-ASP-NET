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
    public class FormationConfig : EntityTypeConfiguration<Formation>
    {
        
        public FormationConfig()
        {
            ToTable("Formation");
            HasKey(f => f.FormId);

            Property(f => f.FormId).HasColumnName("FORM_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.FormIntitule).HasColumnName("FORM_INTITULE").IsRequired().HasMaxLength(50);
            Property(f => f.FormDate).HasColumnName("FORM_DATE").IsRequired();

            HasRequired(em => em.Employe).WithMany(f => f.Formations).HasForeignKey(f =>f.EmpId);
        }
    }
}
