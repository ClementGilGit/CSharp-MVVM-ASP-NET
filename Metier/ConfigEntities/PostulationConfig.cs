using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.ConfigEntities
{
    public class PostulationConfig : EntityTypeConfiguration<Postulation>
    {
        public PostulationConfig()
        {
            ToTable("Postulation");
            HasKey(p => new { p.EmpId, p.OffreId });

            Property(p => p.EmpId).HasColumnName("EMP_ID").IsRequired();
            Property(p => p.OffreId).HasColumnName("OFF_ID").IsRequired();

            Property(p => p.PosDate).HasColumnName("POS_DATE").IsRequired();
            Property(p => p.PosStatut).HasColumnName("POS_STATUT").IsRequired().HasMaxLength(50);

            HasRequired(o => o.Offre).WithMany(p => p.Postulations).HasForeignKey(p => p.OffreId);
            HasRequired(e => e.Employe).WithMany(p => p.Postulations).HasForeignKey(p => p.EmpId);

        }

    }
}
