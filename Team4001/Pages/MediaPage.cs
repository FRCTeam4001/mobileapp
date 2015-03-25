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
        public MediaPage()
            : base()
        {
            Title = "Media"; 
            Icon = "MediaIcon.png"; 

            Content = new ScrollView
            { 
                HorizontalOptions = LayoutOptions.Center,

                Content = new StackLayout
                {
                    Children =
                    {
                        new CardView(
                            new HeadingView("Late O'Clock News"),
                            new VideoView("LateOClockNews.mp4", 854.0f, 476.0f),
                            new ParagraphView("Team 4001 appears on Late O'Clock News with Paul Lemieux!")
                        ),

                        new CardView(
                            new HeadingView("Rogers Daytime Television"),
                            new VideoView("RogersDaytime.mp4", 596.0f, 336.0f),
                            new ParagraphView("Team 4001 appears on Rogers Daytime Television!")
                        ),

                        new CardView(
                            new HeadingView("All About Them Totes"),
                            new VideoView("Totes.mp4", 640.0f, 360.0f),
                            new ParagraphView("A video we created for the 2015 FIRST Robotics Challenge: Recycle Rush.")
                        ),
                    }
                }
            };

        }
    }
}


