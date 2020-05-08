using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace miemss_xamarin
{
    class PediatricDrugViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _doseInstruction;

        public string DoseInstruction
        {
            set
            {
    
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
