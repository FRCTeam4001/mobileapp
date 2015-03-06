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
                            new ImageView("Team4001WithRobot.png"),
                            new ParagraphView("FIRST Robotics Team 4001 is from St. Robert Catholic School in Thornhill, ON, Canada. As a four-year old FRC team, we've accomplished and grown a lot in terms of our technical capabilities of buildilng a robot and our community outreach.")
                        ),
                        new CardView(
                            new HeadingView("2014 - 2015"),
                            new ImageView("IMG_20150305_111349.jpg"),
                            new ParagraphView("- Helped support and start 15 Jr. FLL teams at Holy Spirit in Aurora\n- Hosted Rookie Night 2014\n- Appeared on Rogers TV Daytime Show on February 27, 2015\n\t- All girls appearance with robot and one engineer\n- Opened school to host other teams for Kick-Off Jan 3rd\n- Hosted FLL York Qualifier for the second time on Dec. 13th\n\t- 26 teams\n\t- 80 student volunteers\n\t- Alumni volunteers\n\t- Lego Canada participation\n\t- Liberal newspaper covered it (STEM promotion)\n- High school co-op student placement at Quanser Inc. in Markham, ON.\n- New host for FRC Help Centre Walk in Clinics \n\t- Provided assistance to rookie and second year teams\n\t- Teams helped: 188, 5596, 5598, 4807 and 5158\n- Helped start FLL team at Silverstream school\n- Assisted 5598 and 4807 in programming robots in the LabVIEW environment\n")
                        ),
                        new CardView(
                            new HeadingView("STEM Stats"),
                            new ImageView("IMG_20150305_105500.jpg"),
                            new ParagraphView("St. Robert CHS sends on average 85% of graduating students to a University program. \n\n2011 - no FRC Team\n- 117 of 308 grads enter STEM programs at Universities ( 38%)\n\n2012 - year one of FRC\n- 133 of 297 grads enter STEM ( 44.7%)\n- 3 of 3 FRC team 4001 members go into STEM (100%)\n\n2013- year two of FRC\n- 152 of 285 grads enter STEM (53.3%)\n- 11 of 14 from team (78.6%)\n\n2014- year three of FRC\n- 158 of 331 grads enter STEM (47%)\n- 19 of 23 from team (82.6%)\n")
                        ),
                    }
                }

            };
        }
    }
}


