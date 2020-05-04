using miemss_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace miemss_xamarin.Models
{
    public class RegionGroup : ObservableCollection<HospitalContact>
    {
        public string RegionName { get; private set; }
        public RegionGroup(string name)
            : base()
        {
            RegionName = name;
        }

        public RegionGroup(string name, IEnumerable<HospitalContact> source)
            : base(source)
        {
            RegionName = name;
        }
    }
}
