using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace miemss_xamarin.Models
{
    public static class HospitalContactData
    {
        // Enumeration - The index of the hospital record
        enum HospitalRecordEnum
        {
            Region = 0,
            Name,
            Address,
            PhoneNum,
            Website,
            Type,
            Specialty,
            Specialty2,
            Specialty3
        }
        public static IList<HospitalContact> HospitalContacts { get; private set; }
        static HospitalContactData()
        {
            HospitalContacts = new List<HospitalContact>();
        }

        public static void LoadDatabase()
        {
            // Read each line of the file in the hospital database into a hospital contact list. 
            // Each element of the hospital list is one line of the file.
            Assembly assembly = Assembly.GetExecutingAssembly();
            const string NAME = "miemss_xamarin.Files.hospital_lists_updated.txt";
               
            using (Stream stream = assembly.GetManifestResourceStream(NAME))
            {
             
                using (var f = new StreamReader(stream))
                {
                    string line = string.Empty;

                    // Clear and Populate the hospital contact list by reading each line 
                    // from the database
                    HospitalContacts.Clear();

                    while ((line = f.ReadLine()) != null)
                    {
                        var records = line.Split(';'); 
                        
                        HospitalContacts.Add(new HospitalContact
                        {
                            Region = records[(int)HospitalRecordEnum.Region],
                            Name = records[(int)HospitalRecordEnum.Name],
                            Address = records[(int)HospitalRecordEnum.Address],
                            PhoneNum = records[(int)HospitalRecordEnum.PhoneNum],
                            Website = records[(int)HospitalRecordEnum.Website],
                            Type = records[(int)HospitalRecordEnum.Type],
                            Specialty = records[(int)HospitalRecordEnum.Specialty], 
                            Specialty2 = records[(int)HospitalRecordEnum.Specialty2],
                            Specialty3 = records[(int)HospitalRecordEnum.Specialty3]                            
                        });

                    }
                }
            }
        }
    }
}