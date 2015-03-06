//
//  TeamPage.cs
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
    public class TeamPage : BasePage
    {
        public TeamPage()
            : base()
        {
            Title = "Team"; 
            Icon = "TeamIcon.png";

            Content = new ScrollView
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        new CardView(
                            new HeadingView("Heading"),
                            new ImageView("Team4001WithRobot.png"),
                            new ParagraphView("Some paragraph text. \n - Point 1 \n - Point 2")
                        )
                    }
                }

            };
        }
    }
}


