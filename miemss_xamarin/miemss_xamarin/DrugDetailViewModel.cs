using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace miemss_xamarin
{
    class DrugDetailViewModel : INotifyPropertyChanged
    {
        private bool _isCalculatorVisible;

        public bool IsCalculatorVisible
        {
            get
            {
                return _isCalculatorVisible;
            }
            set
            {
                _isCalculatorVisible = value;
                OnPropertyChanged("IsCalculatorVisible");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
