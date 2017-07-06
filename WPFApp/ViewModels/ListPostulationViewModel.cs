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
    class ListPostulationViewModel : BaseViewModel
    {
        #region variables

        private ObservableCollection<DetailPostulationViewModel> _postulations = null;
        private DetailPostulationViewModel _selectedPostulation;
        #endregion

        #region Constructeurs

        public ListPostulationViewModel()
        {
            _postulations = new ObservableCollection<DetailPostulationViewModel>();
            foreach (Postulation p in BusinessManager.Instance.GetAllPostulation())
            {
                DetailPostulationViewModel pvm = new DetailPostulationViewModel(p);
                _postulations.Add(pvm);
            }

            if (_postulations != null && _postulations.Count > 0)
                _selectedPostulation = _postulations.ElementAt(0);
        }
        #endregion

    }
}
