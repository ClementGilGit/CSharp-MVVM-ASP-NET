using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.ConfigEntities
{
    public class StatutConfig : EntityTypeConfiguration<Statut>
    {
        public StatutConfig()
        {
            ToTable("Statut");
            HasKey(s => s.StaId);

            Property(s => s.StaId).HasColumnName("STAT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.StaLibelle).HasColumnName("STAT_LIBELLE").IsRequired().HasMaxLength(50);
        }
    }
}
