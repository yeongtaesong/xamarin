using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using miemss_xamarin.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_iOS))]
namespace miemss_xamarin.iOS
{
    class BaseUrl_iOS:IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}