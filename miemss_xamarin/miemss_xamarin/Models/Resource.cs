using System;
using System.Collections.Generic;
using System.Text;

/*This model is NOT on SQLite database.*/
namespace miemss_xamarin.Models
{
    public class Resource
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsWebView { get; set; }
    }
}
