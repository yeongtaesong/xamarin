
using miemss_xamarin.Droid;

//Implementation of IBaseUrl for android device. Function will access Assets folder

[assembly: Xamarin.Forms.Dependency(typeof(BaseUrl_Android))]
namespace miemss_xamarin.Droid
{
    class BaseUrl_Android:IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}