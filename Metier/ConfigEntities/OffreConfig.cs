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
    public class OffreConfig : EntityTypeConfiguration<Offre>
    {
        public OffreConfig()
        {
            ToTable("Offre");
            HasKey(o => o.OffreId);

            Property(o => o.OffreId).HasColumnName("OFFRE_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.OffreIntitule).HasColumnName("OFFRE_INTITULE").IsRequired().HasMaxLength(50);
            Property(o => o.OffreDate).HasColumnName("OFFRE_DATE").IsRequired();
            Property(o => o.OffreSalaire).HasColumnName("OFFRE_SALAIRE").IsRequired();
            Property(o => o.StatId).HasColumnName("STAT_ID").IsRequired();
            Property(o => o.OffreDescription).HasColumnName("OFFRE_DESCRIPTION").IsRequired().HasMaxLength(200);
            Property(o => o.OffreResponsable).HasColumnName("OFFRE_RESPONSABLE").IsRequired().HasMaxLength(50);

            HasRequired(s => s.Statut).WithMany(o => o.Offres).HasForeignKey(o => o.StatId);
        }
    }
}
