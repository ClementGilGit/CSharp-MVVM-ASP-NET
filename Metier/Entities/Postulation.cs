 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Postulation
    {
        public int OffreId { get; set; }
        public int EmpId { get; set; }
        public DateTime PosDate { get; set; }
        public string PosStatut { get; set; }

        public Employe Employe { get; set; }

        public Offre Offre { get; set; }
    }
}
