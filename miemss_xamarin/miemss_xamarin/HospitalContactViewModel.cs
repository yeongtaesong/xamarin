using System;
using System.Collections.Generic;
using System.Text;
using miemss_xamarin.Models;

namespace miemss_xamarin
{
    // This is a view model to control a view of Hospital contacts
    // The HospitalPage uses this view model to get detailed hostpital contacts
    public class HospitalContactViewModel
    {
        // Set a list of hospital contacts
        public IList<HospitalContact> HospitalContacts { get; private set; }
        public HospitalContactViewModel()
        {
            // Read and Load a list of hospital contacts from 'Models' folder 
            HospitalContactData.LoadDatabase();
            HospitalContacts = HospitalContactData.HospitalContacts;
        }
    }
}