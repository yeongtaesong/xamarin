using System;
using System.Collections.Generic;
using System.Text;
using miemss_xamarin.Models;

namespace miemss_xamarin
{
    public class HospitalContactViewModel
    {
        public IList<HospitalContact> HospitalContacts { get; private set; }
        public HospitalContactViewModel()
        {
            HospitalContactData.LoadDatabase();
            HospitalContacts = HospitalContactData.HospitalContacts;
        }
    }
}