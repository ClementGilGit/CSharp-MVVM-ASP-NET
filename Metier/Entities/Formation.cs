using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Formation
    {
        public int FormId { get; set; }
        public int EmpId { get; set; }
        public Employe Employe { get; set; }
        public string FormIntitule { get; set; }
        public DateTime FormDate { get; set; }
    }
}
