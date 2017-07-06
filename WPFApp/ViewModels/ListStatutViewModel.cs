using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.ViewModels.Common;

namespace WPFApp.ViewModels
{
    class ListStatutViewModel : BaseViewModel
    {

        #region variables
        private ObservableCollection<DetailStatutViewModel> _statuts = null;
        private DetailStatutViewModel _selectedStatut;
        #endregion


        #region Constructeurs

        public ListStatutViewModel()
        {
            _statuts = new ObservableCollection<DetailStatutViewModel>();
            foreach (Statut s in BusinessManager.Instance.GetAllStatut())
            {
                DetailStatutViewModel svm = new DetailStatutViewModel(s);
                _statuts.Add(svm);
            }

            if (_statuts != null && _statuts.Count > 0)
                _selectedStatut = _statuts.ElementAt(0);
        }
        #endregion
    }
}
