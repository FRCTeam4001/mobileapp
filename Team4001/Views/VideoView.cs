//
// VideoView.cs
//
// Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
// Copyright (c) 2015 Quanser Inc.
//
using System;

using Xamarin.Forms;

namespace Team4001
{
    public class VideoView : View
    {
        public string Filename { get; private set; }

        public float Width { get; private set; }

        public float Height { get; private set; }

        public VideoView(string Filename, float Width, float Height)
        {
            this.Filename = Filename; 
            this.Width = Width; 
            this.Height = Height; 
        }
    }
}