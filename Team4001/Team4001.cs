//
//  Team4001.cs
//
//  Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
//  Copyright (c) 2015 Quanser Inc.
//
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Team4001
{
    public class App : Application
    {
        public App()
        {
            MainPage = new RootPage(); 
        }

        public static class Colours
        {
            public static Color Brand = Color.FromHex("FF9600");
            public static Color BrandDark = Color.FromHex("EF8D00");
            public static Color Background = Color.FromHex("E2E2E2");
        }
    }

    public class RootPage : NavigationPage
    {
        public RootPage()
            : base(new DetailPage())
        {
            BarTextColor = Color.White; 

            Device.OnPlatform(
                
                // iOS
                () =>
                {
                    BarBackgroundColor = App.Colours.Brand;
                }, 

                // Android
                () =>
                {
                    BarBackgroundColor = App.Colours.BrandDark;
                }
            );
        }
    }

    public class DetailPage : TabbedPage
    {
        public DetailPage()
        {
            Device.OnPlatform(
                
                // iOS
                () =>
                {
                    Title = "Team 4001: Retro Rams"; 
                },

                // Android
                () =>
                {
                    Title = "Retro Rams"; 
                }
            );

            BackgroundColor = App.Colours.Background; 

            Children.Add(new TeamPage()); 
            Children.Add(new RobotPage()); 
            Children.Add(new MediaPage()); 
        }
    }
}

