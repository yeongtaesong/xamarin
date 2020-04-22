using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Messaging;
using miemss_xamarin.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(miemss_xamarin.NewView), typeof(NewViewRenderer))]

namespace miemss_xamarin.Droid
{
    //  public class NewViewRenderer : ViewRenderer <miemss_xamarin.NewView,miemss_xamarin.Droid.NewViewRenderer>
    public class NewViewRenderer : ViewRenderer<NewView, Android.Views.View>

    {
        NewViewRenderer newViewRenderer;
        public static Android.Widget.Switch btnRegion1;
        public static Android.Widget.Switch btnRegion2;
        public static Android.Widget.Switch btnRegion3;
        public static Android.Widget.Switch btnRegion4;
        public static Android.Widget.Switch btnRegion5;
        public static Android.Widget.TextView msgText;
        Context context;
        public NewViewRenderer(Context context) : base(context)
        {
            this.context = context;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<NewView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                //  var context = new NewViewRenderer(Forms.Context);
                //SetNativeControl(context);
                var context = Android.App.Application.Context;
                var view = LayoutInflater.From(context).Inflate(Resource.Layout.NotificationLayout, null, false);
                //   LayoutInflater minflater = context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
                //  var view = minflater.Inflate(Resource.Layout.NotificationLayout, this, false);
                var msgText = view.FindViewById<TextView>(Resource.Id.msgText);
                btnRegion1 = view.FindViewById<Android.Widget.Switch>(Resource.Id.SubscribeToRegion1);
                btnRegion2 = view.FindViewById<Android.Widget.Switch>(Resource.Id.SubscribeToRegion2);
                btnRegion3 = view.FindViewById<Android.Widget.Switch>(Resource.Id.SubscribeToRegion3);
                btnRegion4 = view.FindViewById<Android.Widget.Switch>(Resource.Id.SubscribeToRegion4);
                btnRegion5 = view.FindViewById<Android.Widget.Switch>(Resource.Id.SubscribeToRegion5);
                SetNativeControl(view);

                //show saved settings 
                if (Preferences.ContainsKey("R1"))
                {
                    string R1 = Preferences.Get("R1", "");
                    if (R1 == "1")
                        btnRegion1.Checked = true;
                    else
                        btnRegion1.Checked = false;
                }
                if (Preferences.ContainsKey("R2"))
                {
                    string R2 = Preferences.Get("R2", "");
                    if (R2 == "1")
                        btnRegion2.Checked = true;
                    else
                        btnRegion2.Checked = false;
                }
                if (Preferences.ContainsKey("R3"))
                {
                    string R3 = Preferences.Get("R3", "");
                    if (R3 == "1")
                        btnRegion3.Checked = true;
                    else
                        btnRegion3.Checked = false;
                }
                if (Preferences.ContainsKey("R4"))
                {
                    string R4 = Preferences.Get("R4", "");
                    if (R4 == "1")
                        btnRegion4.Checked = true;
                    else
                        btnRegion4.Checked = false;
                }
                if (Preferences.ContainsKey("R5"))
                {
                    string R5 = Preferences.Get("R5", "");
                    if (R5 == "1")
                        btnRegion5.Checked = true;
                    else
                        btnRegion5.Checked = false;
                }

                //end remember settings ----------
            }
            if (e.NewElement != null)
            {
                btnRegion1.CheckedChange += (a, b) =>
                {
                    bool isChecked = b.IsChecked;
                    if (isChecked)
                    {
                        FirebaseMessaging.Instance.SubscribeToTopic("R1");
                        Preferences.Set("R1", "1");
                    }
                    else
                    {
                        FirebaseMessaging.Instance.UnsubscribeFromTopic("R1");
                        Preferences.Set("R1", "0");
                    }
                };

                btnRegion2.CheckedChange += (c, d) =>
                {
                    bool isChecked = d.IsChecked;
                    if (isChecked)
                    {
                        FirebaseMessaging.Instance.SubscribeToTopic("R2");
                        Preferences.Set("R2", "1");
                    }
                    else
                    {
                        FirebaseMessaging.Instance.UnsubscribeFromTopic("R2");
                        Preferences.Set("R2", "0");
                    }
                };

                btnRegion3.CheckedChange += (e, f) =>
                {
                    bool isChecked = f.IsChecked;
                    if (isChecked)
                    {
                        FirebaseMessaging.Instance.SubscribeToTopic("R3");
                        Preferences.Set("R3", "1");
                    }
                    else
                    {
                        FirebaseMessaging.Instance.UnsubscribeFromTopic("R3");
                        Preferences.Set("R3", "0");
                    }
                };

                btnRegion4.CheckedChange += (g, h) =>
                {
                    bool isChecked = h.IsChecked;
                    if (isChecked)
                    {
                        FirebaseMessaging.Instance.SubscribeToTopic("R4");
                        Preferences.Set("R4", "1");
                    }
                    else
                    {
                        FirebaseMessaging.Instance.UnsubscribeFromTopic("R4");
                        Preferences.Set("R4", "0");

                    }
                };

                btnRegion5.CheckedChange += (i, j) =>
                {
                    bool isChecked = j.IsChecked;
                    if (isChecked)
                    {
                        FirebaseMessaging.Instance.SubscribeToTopic("R5");
                        Preferences.Set("R5", "1");
                    }
                    else
                    {
                        FirebaseMessaging.Instance.UnsubscribeFromTopic("R5");
                        Preferences.Set("R5", "0");

                    }
                };
            }

        }
    }

}
