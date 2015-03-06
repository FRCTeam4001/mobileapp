//
// HeadingView.cs
//
// Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
// Copyright (c) 2015 Quanser Inc.

using System;
using Xamarin.Forms;

namespace Team4001
{
    public class HeadingView : Label
    {
        public HeadingView(string Text)
        {
            this.Text = Text; 
            FontAttributes = FontAttributes.Bold;
        }
    }
}

