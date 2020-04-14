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
                Name = "Anne Arundel Medical Center",
                Address = "2001 Medical Pkwy, Annapolis, MD 21401",
                PhoneNum = "111-223-1234",
                Website = "www.jhu.edu",
                Type = "Level I Trauma Center",
                Specialty = "Cardiac  ",
                Burn = "YES",
                Stroke = "YES"
            });
            HospitalContacts.Add(new HospitalContact
            {
                Name = "Baltimore Washington Medical Center (UM)",
                Address = "",
                PhoneNum = "",
                Website = "",
                Type = "Level I Trauma Center",
                Specialty = "  ",
                Burn = "YES",
                Stroke = "YES"
            });

            HospitalContacts.Add(new HospitalContact
            {
                Name = "Carroll Hospital Center",
                Address = "",
                PhoneNum = "",
                Website = "",
                Type = "LeveI Trauma Center",
                Specialty = "  ",
                Burn = "YES",
                Stroke = "YES"
            });
            HospitalContacts.Add(new HospitalContact
            {
                Name = "Christiana Care Health System",
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
