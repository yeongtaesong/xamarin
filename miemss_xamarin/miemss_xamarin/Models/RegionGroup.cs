using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace miemss_xamarin.Models
{
    // Set a list of Regions for grouping hospitals by Region
    public class RegionGroup : ObservableCollection<HospitalContact>
    {
        public string RegionName { get; private set; }
        public RegionGroup(string name)
            : base()
        {
            RegionName = name;
        }
    // Values of Regions are extracted from HospitalContactData in "Model" folder
        public RegionGroup(string name, IEnumerable<HospitalContact> source)
            : base(source)
        {
            RegionName = name;
        }
    }
}
