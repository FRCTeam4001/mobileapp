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
using System.Collections.Generic;

namespace Team4001
{
    public class RobotPage : BasePage
    {
        public RobotPage()
            : base()
        {
            Title = "Robot";
            Icon = "RobotIcon.png"; 

            ImageView elevateImage = new ImageView("RobotRender3.png");
            ImageView autoImage = new ImageView("RobotRender5.png");
            ImageView controlImage = new ImageView("RobotRender4.png");

            List<Team4001.TeamPage.Achievement> elevator = new List<Team4001.TeamPage.Achievement>
            {
                new Team4001.TeamPage.Achievement("Elevator Design", "Elevator uses a simple design to load two sets of two totes", "vehicle57.png", "RobotRender3.png"),
                new Team4001.TeamPage.Achievement("Human Player Station", "Elevator is designed to load from the human player without a ramp", "man13.png", "Loading.jpg"),
                new Team4001.TeamPage.Achievement("Limited Workspace", "Loading strategy is optimized to reduce time required for transportation", "car186.png", "Stack.jpg"),
                new Team4001.TeamPage.Achievement("Multifunctional Arms", "Multifunctional arms are designed to pick up totes or bins", "factory26.png", "RobotRender4.png"),
                new Team4001.TeamPage.Achievement("Scoring", "Loading totes on the opposite side from bins and noodles enables us to score a complete 5 stack", "garbage8.png", "Noodle.jpg")
            };


            List<Team4001.TeamPage.Achievement> auto = new List<Team4001.TeamPage.Achievement>
            {
                new Team4001.TeamPage.Achievement("Move", "Move into autonomous zone", "car186.png", "RobotRender5.png"),
                new Team4001.TeamPage.Achievement("Tote and Move", "Pick up tote and move into autonomous zone", "open208.png", "BinDrop.jpg"),
                new Team4001.TeamPage.Achievement("Bin and Move", "Pick up bin and move into autonomous zone", "garbage8.png", "Bin.jpg"),
                    new Team4001.TeamPage.Achievement("Bin and Tote", "Pick up bin and tote before preparing for teleop", "joystick10.png", "IMG_20150305_111340.png")
            };
            

            List<Team4001.TeamPage.Achievement> controller = new List<Team4001.TeamPage.Achievement>
            {
                    new Team4001.TeamPage.Achievement("Encoders", "PI control to hold loading arm position while loading totes", "car186.png"),
                    new Team4001.TeamPage.Achievement("Gyroscope", "PD control to maintain heading while maneuvering", "vehicle57.png"),
                    new Team4001.TeamPage.Achievement("Short-Range IR", "Autonomous scoring platform detection", "garbage8.png"),
                    new Team4001.TeamPage.Achievement("Long-Range IR", "Collision avoidance during navigation", "vehicle57.png")
            };

            var cell = new DataTemplate(typeof(ImageCell));

            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(TextCell.DetailProperty, "Details");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

            ListView elevatorList = new ListView{ ItemsSource = elevator, ItemTemplate = cell };
            ListView autoList = new ListView{ ItemsSource = auto, ItemTemplate = cell };
            ListView controllerList = new ListView{ ItemsSource = controller, ItemTemplate = cell };

            elevatorList.ItemSelected += async (sender, e) =>
            {
                Team4001.TeamPage.Achievement target = ((Team4001.TeamPage.Achievement)(e.SelectedItem));
                if (target.Highlight != null)
                {
                    elevateImage.Source = target.Highlight;
                }
            };

            autoList.ItemSelected += async (sender, e) =>
                {
                    Team4001.TeamPage.Achievement target = ((Team4001.TeamPage.Achievement)(e.SelectedItem));
                    if (target.Highlight != null)
                    {
                        autoImage.Source = target.Highlight;
                    }
                };

            Content = new ScrollView
            { 
                Content = new StackLayout
                {
                    Children =
                    {
                        new CardView(
                            new ImageView("IMG_20150305_120103.png"),
                            new ParagraphView("For this build season, we designed and built a robot to address a very specific strategy to maximimize the size of our tote stacks by maximizing our operational efficiency within a small region of the game field.")
                        ),
                        new CardView(
                            new HeadingView("Recycle Rush Robot Design"),
                            elevateImage                           
                            //new ParagraphView("The front-side of our robot was designed to sequentially load four totes from the human operator station. By optimizing this loading strategy, we limit our workspace to a small area between the human loading station and the adjacent scoring platform. This illiminates any potential risks involving having to traverse a complex terrain filled with litter (pool noodles).")
                        ),
                        new CardView(
                            elevatorList
                        ),
                        new CardView(
                            new HeadingView("Autonomous Modes"),
                            autoImage,
                            autoList
                            //new ParagraphView("To maximize our versatility when forming alliances with other teams, our robot is capable of several autonomous modes which are selected at the driver station depending on the capabilities of other team members:\n\t1. Move into autonomous zone.\n\t2. Pick up tote and move into autonomous zone.\n\t3. Pick up container and move into autonomous zone.\n\t4. Pick up container, tote and prepare for teleop.")
                        ),
                        new CardView(
                            new HeadingView("Sensors & Control"),
                            new ImageView("RobotRender4.png"),
                            new ParagraphView("Our robot utilizes several sensors in order to accomplish autonomous tasks and to aid the driver during teleop:"),
                                        controllerList
                        ),
                    }
                }
            };
        }
    }
}


