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
        public RobotPage()
            : base()
        {
            Title = "Robot";
            Icon = "RobotIcon.png"; 

            Content = new ScrollView
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        new CardView(
                            new ImageView("IMG_20150305_120103.jpg"),
                            new ParagraphView("For this build season, we designed and built a robot to address a very specific strategy to maximimize the size of our tote stacks by maximizing our operational efficiency within a small region of the game field.")
                        ),
                        new CardView(
                            new HeadingView("Recycle Rush Robot Design"),
                            new ImageView("RobotRender3.png"),
                            new ParagraphView("The front-side of our robot was designed to sequentially load four totes from the human operator station. By optimizing this loading strategy, we limit our workspace to a small area between the human loading station and the adjacent scoring platform. This illiminates any potential risks involving having to traverse a complex terrain filled with litter (pool noodles)."),
                            new ImageView("RobotRender1.png"),
                            new ParagraphView("The back-side of our robot was designed to pick up either totes or containers with robotic gripper arms powered by pneumatics. This side of our robot allows us to simultaneously load four totes on the front-side while we load a tote-and-container stack on the backside to score an impressive 5 stack + container combination.")
                        ),
                        new CardView(
                            new HeadingView("Autonomous Mode"),
                            new ImageView("RobotRender5.png"),
                            new ParagraphView("To maximize our versatility when forming alliances with other teams, our robot is capable of several autonomous modes which are selected at the driver station depending on the capabilities of other team members:\n\t1. Move into autonomous zone.\n\t2. Pick up tote and move into autonomous zone.\n\t3. Pick up container and move into autonomous zone.\n\t4. Pick up container, tote and prepare for teleop.")
                        ),
                        new CardView(
                            new HeadingView("Sensors & Control"),
                            new ImageView("RobotRender4.png"),
                            new ParagraphView("Our robot utilizes several sensors in order to accomplish autonomous tasks and to aid the driver during teleop:\n\t1. Encoders with PI control to hold loading arm position while loading totes\n\t2. Gyroscope with PD control to maintain heading while maneuvering\n\t3. Short-range IR sensors for autonomous detection of scoring platform\n\t4. Long-range IR sensors for collision avoidance and cruise control")
                        ),
                    }
                }
            };
        }
    }
}


