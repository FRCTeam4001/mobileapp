//
//  AppDelegate.cs
//
//  Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
//  Copyright (c) 2015 Quanser Inc.
//
//
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Team4001.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            UITabBar.Appearance.TintColor = new UIColor(255.0f / 255.0f, 150.0f / 255.0f, 0.0f / 255.0f, 1.0f); 

            return base.FinishedLaunching(app, options);
        }
    }
}

