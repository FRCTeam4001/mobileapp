//
//  MediaPage.cs
//
//  Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
//  Copyright (c) 2015 Quanser Inc.
//
//
using System;

using Xamarin.Forms;

namespace Team4001
{
    public class MediaPage : BasePage
    {
        public MediaPage() : base()
        {
            Title = "Media"; 
            Icon = "MediaIcon.png"; 

            Content = new StackLayout
            { 
                Children =
                {
                    new Label { Text = String.Empty }
                }
            };
        }
    }
}


