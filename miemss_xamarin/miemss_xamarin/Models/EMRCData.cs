using System;
using System.Collections.Generic;
using System.Text;

namespace miemss_xamarin.Models
{
    public class EMRCData
    {
        public static IList<EMRC> EMRCs { get; private set; }
        static EMRCData()
        {
            EMRCs = new List<EMRC>();

            EMRCs.Add(new EMRC
            {
                Name = "Commercial Ambulance Licensing and Regulation Office ",
                Phone = "(410) 706-8511 "
            });

            EMRCs.Add(new EMRC
            {
                Name = "Critical Incident Stress Management ",
                Phone = "(800) 648-3001 "
            });
            EMRCs.Add(new EMRC
            {
                Name = "Office of Licensure and Certification Office ",
                Phone = "(800) 762-7157 "
            });

            EMRCs.Add(new EMRC
            {
                Name = "Region I EMRC  ",
                Phone = "(301) 722-0494"
            });
            EMRCs.Add(new EMRC
            {
                Name = "Region II EMRC",
                Phone = "(301) 722-0494"
            });
            EMRCs.Add(new EMRC
            {
                Name = "Region III EMRC",
                Phone = "(800) 492-3805"
            });

            EMRCs.Add(new EMRC
            {
                Name = "Region IV EMRC",
                Phone = "(877) 963-6963"
            });
            EMRCs.Add(new EMRC
            {
                Name = "Region V EMRC",
                Phone = "(877) 840- 4245"
            });
            EMRCs.Add(new EMRC
            {
                Name = "Poison Control",
                Phone = "(800) 492-3805"
            });

            EMRCs.Add(new EMRC
            {
                Name = "Maryland Donor Referral Line Living Legacy (Majority of Maryland)",
                Phone = "(800) 923-1133"
            });
            EMRCs.Add(new EMRC
            {
                Name = "Washington Regional Transplant Community  (Charles, Montgomery, and Prince George’s counties)",
                Phone = "(703) 641-0100"
            });
        }
    }
}
