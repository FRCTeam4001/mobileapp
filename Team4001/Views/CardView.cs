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
                {
                    if (Type.Equals(view.GetType(), typeof(ListView)))
                    {
                        var items = ((ListView)(view)).ItemsSource.OfType<Team4001.TeamPage.Achievement>().Count();
                        view.HeightRequest = 45*items;
                    }
                    layout.Children.Add(view);
                }

                Content = layout; 
            }
        }
    }
}


