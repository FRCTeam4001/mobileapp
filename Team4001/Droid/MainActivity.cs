//
// MainActivity.cs
//
// Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
// Copyright (c) 2015 Quanser Inc.

using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Team4001.Droid
{
    [Activity(Label = "Retro Rams", Icon = "@drawable/icon", Theme = "@style/Team4001Theme",
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

