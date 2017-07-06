using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier.Entities;
using WPFApp.ViewModels.Common;

namespace WPFApp.ViewModels
{
    class DetailStatutViewModel
    {
        #region Variables
        private String _staLibelle;
        #endregion

        #region Constructeur
        public DetailStatutViewModel(Statut s)
        {
            _staLibelle = s.StaLibelle;
        }
        #endregion

        #region Data Bindings
        public String StaLibelle
        {
            get { return _staLibelle; }
            set { _staLibelle = value; }
        }
        #endregion

    }
}
