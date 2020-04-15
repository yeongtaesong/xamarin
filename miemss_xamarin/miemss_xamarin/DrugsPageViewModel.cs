using System;
using System.Collections.Generic;
using System.Text;
using miemss_xamarin.Models;

namespace miemss_xamarin
{
    public class DrugsPageViewModel
    {
        public IList<Drug> Drugs { get; private set; }

        public DrugsPageViewModel()
        {
            Drugs = DrugData.Drugs;
        }
    }
}
