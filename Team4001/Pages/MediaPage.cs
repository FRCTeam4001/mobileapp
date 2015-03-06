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
        private static readonly string TOTES_VIDEO = "https://vimeo.com/121322118";

        public MediaPage()
            : base()
        {
            Title = "Media"; 
            Icon = "MediaIcon.png"; 

            Content = new WebView { Source = TOTES_VIDEO };

        }
    }
}


