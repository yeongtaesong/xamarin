using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using miemss_xamarin.iOS;
using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Firebase.CloudMessaging;


[assembly: ExportRenderer(typeof(miemss_xamarin.NewView), typeof(miemss_xamarin.iOS.NewViewRenderer))]
namespace miemss_xamarin.iOS
{
    public class NewViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            SetupUserInterface();

        }

        private string[] OnesLetters =
          { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private string IntegerToRoman(int numVar)
        {
   
            string result = "";

            // Otherwise process the letters.
            // Handle ones.
            result += OnesLetters[numVar];

            return result;
        }
        void SetupUserInterface()
        {
            //Add Header
            UILabel lblHeader = new UILabel(new RectangleF(50, 20, 300, 50));
            lblHeader.Text = "Message Notifications For: ";
            this.Add(lblHeader);

            //Add Regions
            for (int i = 0; i < 5; i++)
            {
                UILabel lblRegion = new UILabel(new RectangleF(50, (i + 1) * 50 + 10, 150, 50));
                lblRegion.Text = "Region " + IntegerToRoman(i + 1);

                UISwitch btnRegion = new UISwitch(new RectangleF(300, (i + 1) * 50 + 10, 150, 50));

                string key = "R" + (i + 1).ToString();
                btnRegion.On = Preferences.ContainsKey(key) && Preferences.Get(key, "") == "1" ? true : false;
                btnRegion.ValueChanged += delegate (object sender, EventArgs e) {
                    Preferences.Set(key, btnRegion.On == true ? "1" : "0");
                   
                    if (btnRegion.On == true)
                        Firebase.CloudMessaging.Messaging.SharedInstance.Subscribe(key);
                    else
                        Firebase.CloudMessaging.Messaging.SharedInstance.Unsubscribe(key);
                    

                };

                this.Add(lblRegion);
                this.Add(btnRegion);

            }




        }

    }
}