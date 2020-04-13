using System;
using System.Collections.Generic;
using System.Text;

namespace miemss_xamarin.Models
{
    public static class HospitalContactData
    {
        public static IList<HospitalContact> HospitalContacts { get; private set; }
        static HospitalContactData()

        {
            HospitalContacts = new List<HospitalContact>();

            HospitalContacts.Add(new HospitalContact
            {
                Name = "Johns Hopkins Bayview Medical Center",
                Address = "1111 Habor Rd. Baltimore MD",
                PhoneNum = "111-223-1234",
                Website = "www.jhu.edu",
                Type = "Level I Trauma Center",
                Specialty = "Cardiac  ",
                Burn = "YES",
                Stroke = "YES"
            });
            HospitalContacts.Add(new HospitalContact
            {
                Name = "Johns Hopkins Harbor Medical Center",
                Address = "",
                PhoneNum = "",
                Website = "",
                Type = "LeveI Trauma Center",
                Specialty = "  ",
                Burn = "YES",
                Stroke = "YES"
            });
        }
    }
}
