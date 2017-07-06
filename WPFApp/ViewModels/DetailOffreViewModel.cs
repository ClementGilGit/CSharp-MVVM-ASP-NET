using Metier.Entities;
using Model.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFApp.ViewModels.Common;

namespace WPFApp.ViewModels
{
    class DetailOffreViewModel : BaseViewModel
    {
        #region Variables

        private int _id;
        private string _intitule;
        private DateTime _date;
        private int _salaire;
        private string _description;
        private string _responsable;
        private RelayCommand _addOperation;
        private ObservableCollection<DetailPostulationViewModel> _postulations;
        private ObservableCollection<DetailStatutViewModel> _statuts;
        private DetailStatutViewModel _statut;
        #endregion

        #region Constructeurs

        public DetailOffreViewModel(Offre o)
        {
            _id = o.OffreId;
            _intitule = o.OffreIntitule;
            _date = o.OffreDate;
            _salaire = o.OffreSalaire;
            _description = o.OffreDescription;
            _responsable = o.OffreResponsable;
            List<Statut> statut = BusinessManager.Instance.GetStatutById(o.StatId);
            _statut = new DetailStatutViewModel(statut.ElementAt(0));
        }
        #endregion

        #region Data Bindings


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Intitule
        {
            get { return _intitule; }
            set { _intitule = value; }
        }

        

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public String Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }

        public ObservableCollection<DetailPostulationViewModel> Postulations
        {
            get { return _postulations; }
            set { _postulations = value; OnPropertyChanged("Postulations"); }
        }

        public ObservableCollection<DetailStatutViewModel> Statuts
        {
            get { return _statuts; }
            set { _statuts = value; OnPropertyChanged("Statuts"); }
        }

        public DetailStatutViewModel Statut
        {
            get { return _statut; }
            set
            {
                _statut = value;
                OnPropertyChanged("Statut");
            }
        }
        #endregion

        #region Commandes

        public ICommand AddOperation
        {
            get
            {
                if(_addOperation == null)
                {
                    _addOperation = new RelayCommand(() => this.UpdateWindowOperation());
                }
                return _addOperation;
            }
        }

        public void UpdateWindowOperation()
        {
            BusinessManager.Instance.Modifier(_id,_intitule,_salaire,_description,_responsable); ;
        }

        #endregion
    }
}
