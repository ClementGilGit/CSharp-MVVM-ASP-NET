using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.ViewModels.Common
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Constructeurs

        protected BaseViewModel()
        {

        }

        #endregion

        #region  Membres de INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if(handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        #endregion
    }
}
