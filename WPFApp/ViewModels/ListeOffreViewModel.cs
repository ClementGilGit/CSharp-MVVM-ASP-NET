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
    class ListeOffreViewModel : BaseViewModel
    {
        #region variables

        private ObservableCollection<DetailOffreViewModel> _offres = null;
        private ObservableCollection<DetailPostulationViewModel> _postulations = null;
        private DetailOffreViewModel _selectedOffre;
        #endregion

        #region Constructeurs

        public ListeOffreViewModel()
        {
            _offres = new ObservableCollection<DetailOffreViewModel>();
            foreach(Offre o in BusinessManager.Instance.GetAllOffre())
            {
                //mettre recherche postulations par id
                List<Postulation> postulations = BusinessManager.Instance.GetPostulationById(o.OffreId);
                DetailOffreViewModel ovm = new DetailOffreViewModel(o);
                ObservableCollection<DetailPostulationViewModel> oc = new ObservableCollection<DetailPostulationViewModel>();
                foreach (var item in postulations)
                    oc.Add(new DetailPostulationViewModel(item));
                ovm.Postulations = oc;
                //ovm.Postulations = postulations;

                _offres.Add(ovm);
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffre = _offres.ElementAt(0);
        }
        #endregion

        #region Data Bindings

        public ObservableCollection<DetailOffreViewModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }


        public DetailOffreViewModel SelectedOffre
        {
            get { return _selectedOffre; }
            set
            {
                _selectedOffre = value;
                OnPropertyChanged("SelectedOffre");
            }
        }
        #endregion
    }
}
