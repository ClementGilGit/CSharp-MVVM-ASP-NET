using Metier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.ViewModels.Common;

namespace WPFApp.ViewModels
{
    class DetailPostulationViewModel : BaseViewModel
    {
        #region Variables

        private DateTime _date;
        private RelayCommand _addOperation;
        private Employe _employe;

        #endregion

        #region Constructeurs

        public DetailPostulationViewModel(Postulation p)
        {
            _date = p.PosDate;
            _employe = p.Employe;
        }
        #endregion

        #region Data Bindings

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Employe Employe
        {
            get { return _employe; }
            set { _employe = value; }
        }

        #endregion
    }
}
