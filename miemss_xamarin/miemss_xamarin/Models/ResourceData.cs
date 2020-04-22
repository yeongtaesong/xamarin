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
                Name = "CBRNE Resources",
                Path = "path"
            });

            Resources.Add(new Resource
            {
                Name = "Resource 2",
                Path = "path"
            });

            Resources.Add(new Resource
            {
                Name = "Resource 3",
                Path = "path"
            });
        }

    }
}
