//
// CardView.cs
//
// Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
// Copyright (c) 2015 Quanser Inc.
//
//
using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Team4001
{
    public class CardView : Frame
    {
        public CardView(params View[] views)
        {
            HasShadow = false;

            if (views != null)
            {
                var layout = new StackLayout();

                foreach (var view in views)
                    layout.Children.Add(view); 

                Content = layout; 
            }
        }
    }
}


