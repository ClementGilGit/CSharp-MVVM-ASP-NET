using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Experience
    {
        public int ExpId { get; set; }
        public int EmpId { get; set; }
        public Employe Employe { get; set; }
        public string EmpIntitule { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
