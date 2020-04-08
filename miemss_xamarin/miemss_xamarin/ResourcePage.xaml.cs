using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace miemss_xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourcePage : ContentPage
    {
        public ResourcePage()
        {
            bool isVisibleBinding = new IsVisible().getBool();
            InitializeComponent();
        }
    }

    class IsVisible
    {
        private bool _isVisible;

        public IsVisible()
        {
            _isVisible = true;
        }

        public void setBool()
        {
            if (_isVisible)
            {
                _isVisible = false;
            } else
            {
                _isVisible = true;
            }
        }

        public bool getBool()
        {
            return _isVisible;
        }
       


    }
}