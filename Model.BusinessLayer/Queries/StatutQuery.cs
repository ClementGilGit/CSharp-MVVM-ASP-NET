using Metier.Context;
using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BusinessLayer.Queries
{
    class StatutQuery
    {
        private readonly Context _contexte;

        public StatutQuery(Context contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Statut> GetAll()
        {
            return _contexte.Statuts;
        }

        public IQueryable<Statut> GetBySingleID(int id)
        {
            return _contexte.Statuts.Where(s => s.StaId == id);
        }
    }
}
