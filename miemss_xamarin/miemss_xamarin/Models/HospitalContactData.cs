using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace miemss_xamarin.Models
{
    public static class HospitalContactData
    {
        // Enumeration - The index of the hospital record
        enum HospitalRecordEnum
        {
            Name = 0,
            Address,
            PhoneNum,
            Website,
            Type,
            Specialty,
            Burn,
            Stroke
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
            const string NAME = "miemss_xamarin.Files.hospital_list1.txt";

            using (Stream stream = assembly.GetManifestResourceStream(NAME))
            {
                using (var f = new StreamReader(stream))
                {
                    string line = string.Empty;

                    // Populate the hospital contact list by reading each line from the database
                    while ((line = f.ReadLine()) != null)
                    {
                        var records = line.Split(';');
                        
                        HospitalContacts.Add(new HospitalContact
                        {
                            Name = records[(int)HospitalRecordEnum.Name],
                            Address = records[(int)HospitalRecordEnum.Address],
                            PhoneNum = records[(int)HospitalRecordEnum.PhoneNum],
                            Website = records[(int)HospitalRecordEnum.Website],
                            Type = records[(int)HospitalRecordEnum.Type],
                            Specialty = records[(int)HospitalRecordEnum.Specialty],
                            Burn = records[(int)HospitalRecordEnum.Burn],
                            Stroke = records[(int)HospitalRecordEnum.Stroke]                            
                        });

                    }
                }
            }
        }
    }
}