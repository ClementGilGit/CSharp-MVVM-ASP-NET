using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Entities
{
    public class Offre
    {
        public int OffreId { get; set; }
        public string OffreIntitule { get; set; }
        public DateTime OffreDate { get; set; }
        public int OffreSalaire { get; set; }
        public string OffreDescription { get; set; }
        public int StatId { get; set; }
        public string OffreResponsable { get; set; }
        public Statut Statut { get; set; }

        public ObservableCollection<Postulation> Postulations { get; set; }
    }
}
