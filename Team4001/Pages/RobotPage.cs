//
//  RobotPage.cs
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
    public class RobotPage : BasePage
    {
        public RobotPage() : base()
        {
            Title = "Robot";
            Icon = "RobotIcon.png"; 

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


