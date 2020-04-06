
using Foundation;
using miemss_xamarin.iOS;

//Implementation of IBaseUrl for iOS device. Function will access Resource folder.
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