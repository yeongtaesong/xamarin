using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace miemss_xamarin.Models
{
    public static class ResourceData
    {
        public static IList<Resource> Resources { get; private set; }

        static ResourceData()
        {
            Resources = new List<Resource>();

            Resources.Add(new Resource
            {
                Name = "MIEMSS-Infectious Diseases Program",
                Path = "http://miemss.org/home/infectious-diseases",
                IsWebView = true
            });

            Resources.Add(new Resource
            {
                Name = "CBRNE Resources",
                Path = "miemss_xamarin.Assets.playbook.pdf",
                IsWebView = false
               
            });

            Resources.Add(new Resource
            {
                Name = "Public Health Emergency ASPR Playbooks",
                Path = "https://www.phe.gov/Preparedness/planning/playbooks/Pages/default.aspx",
                IsWebView = true
            });

            Resources.Add(new Resource
            {
                Name = "High Consequence Infectious Disease Toolbox",
                Path = "https://asprtracie.hhs.gov/technical-resources/resource/7123/high-consequence-infectious-disease-hcid-toolbox-for-frontline-health-care-facilities",
                IsWebView = true
            });
        }

    }
}
