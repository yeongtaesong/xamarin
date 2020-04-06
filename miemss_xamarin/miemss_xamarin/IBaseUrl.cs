
namespace miemss_xamarin
{
    /*Use this to obtain path to Android resources or iOS resources. Implementation are in their respective directories. 
     To use this interface do: 

            string path = DependencyService.Get<IBaseUrl>().Get();
            string url = Path.Combine(path, "HTML/filename.html");
            
    All html file will be in resources/HTML found in both iOS and android directory
    Function is used for accessing appropriate directory for placing HTML file. For android, Assets folder will be accessed. 
    For iOS devices, the Resource folder will be accessed.*/
    public interface IBaseUrl
    {
        string Get();
    }
}
