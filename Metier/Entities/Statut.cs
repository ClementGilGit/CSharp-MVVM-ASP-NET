using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Statut
    {
        public int StaId { get; set; }
        public string StaLibelle { get; set; }
        public ICollection<Offre> Offres { get; set; }
    }
}
