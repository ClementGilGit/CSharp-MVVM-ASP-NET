using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Employe
    {
        public int EmpId { get; set; }
        public string EmpNom { get; set; }
        public string EmpPrenom { get; set; }
        public DateTime EmpDateNaissance { get; set; }
        public int EmpAnciennete { get; set; }
        public string EmpBiographie { get; set; }

        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Formation> Formations { get; set; }

        public ICollection<Postulation> Postulations { get; set; }
    }
}
