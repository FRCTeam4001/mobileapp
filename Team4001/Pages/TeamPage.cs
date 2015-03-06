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
using System.Collections.Generic;

namespace Team4001
{
    public class TeamPage : BasePage
    {
        public TeamPage()
            : base()
        {
            Title = "Team"; 
            Icon = "TeamIcon.png";

            List<Achievement> achievements = new List<Achievement>
            {
                new Achievement("Jr. FLL Team Support", "Supported and started 15 Jr. FLL Teams at Holy Spirit in Aurora", "lifebuoy2.png"),
                new Achievement("FLL Support", "Hosted the FLL York Region Qualifier (2nd Year) with 26 teams and 80 student volunteers", "lifebuoy2.png"),
                new Achievement("FLL Promotion", "Liberal Newspaper Coverage of the event", "newspaper20.png"),
                new Achievement("FLL Team Support", "Started FLL team at Silverstream school", "lifebuoy2.png"),
                new Achievement("Regional FRC Walk-In Clinic", "Hosted a regional robot clinic for rookie and second year teams (188, 5596, 5598, 4807 and 5158)", "lifebuoy2.png"),
                new Achievement("FRC Team Support", "Assisted 5598 and 4807 in LabVIEW programming best practices", "lifebuoy2.png"),
                new Achievement("FRC Kickoff Event", "Coordinated a kickoff event with guest speakers and tutorials", "lifebuoy2.png"),
                new Achievement("Co-op Placement", "Team members honed their skills as interns at sponsor company", "college1.png"),
                new Achievement("Media Exposure", "Appeared on Rogers Daytime television, and Comedy Network's The Late O Clock News to promote STEM", "newspaper20.png"),
            };

            List<Achievement> stemStats = new List<Achievement>
            {
                    new Achievement("2011 - No FRC Team", "117 of 308 graduates enter STEM programs (38%)", "tree83.png"),
                    new Achievement("2012 - Year One", "133 of 297 graduates enter STEM programs (45%) and 100% of Team 4001 members", "tree58.png"),
                    new Achievement("2013 - Year Two", "152 of 285 graduates enter STEM programs (53%) and 78% of Team 4001", "tree93.png"),
                    new Achievement("2014 - Year Three", "158 of 331 graduates enter STEM programs (47%) and 82% of Team 4001", "small164.png"),
            };

            var cell = new DataTemplate(typeof(ImageCell));

            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(TextCell.DetailProperty, "Details");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

            Content = new ScrollView
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        new CardView(
                            new HeadingView("2015 Season"),
                            new ImageView("IMG_20150305_111349.jpg")
                        ),
                        new CardView(
                            new ListView{ ItemsSource = achievements, ItemTemplate = cell,  }
                        ),
                        new CardView(
                            new HeadingView("STEM Stats"),
                            new ImageView("IMG_20150305_105500.jpg"),
                            new ParagraphView("St. Robert CHS sends on average 85% of graduating students to a University program.")                        ),
                        new CardView(
                            new ListView{ ItemsSource = stemStats, ItemTemplate = cell,  }
                        ),
                        new CardView(
                            new ImageView("Rebound_BandW.jpg"),
                            new ParagraphView("FIRST Robotics Team 4001 is from St. Robert Catholic School in Thornhill, ON, Canada. As a four-year old FRC team, we've accomplished and grown a lot in terms of our technical capabilities of buildilng a robot and our community outreach.")
                        ),
                    }
                }
            };

        }

        public class Achievement
        {
            public Achievement(string title, string details, string image)
            {
                this.Title = title;
                this.Details = details;
                this.Image = image;
            }

            public string Title { private set; get; }

            public string Details { private set; get; }

            public string Image { private set; get; }
        };
    }
}


