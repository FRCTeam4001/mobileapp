//
// VideoViewRenderer.cs
//
// Author:
//       Safwan Choudhury <safwan.choudhury@quanser.com>
//
// Copyright (c) 2015 Quanser Inc.
//
using Team4001;
using Team4001.iOS;

using Xamarin.Forms;

[assembly: ExportRenderer(typeof(VideoView), typeof(VideoViewRenderer))]
namespace Team4001.iOS
{
    using System;
    using System.Drawing;

    using Foundation;
    using UIKit;
    using MediaPlayer;

    using Xamarin.Forms.Platform.iOS;

    public class VideoViewRenderer : ViewRenderer
    {
        private const float WIDTH_PERCENTAGE = 0.9f;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            var video = (VideoView)e.NewElement;
            var a = video.Height / video.Width;                                      // height / width
            var w = (float)(UIScreen.MainScreen.Bounds.Width) * WIDTH_PERCENTAGE;    // desired width
            var h = w * a;                                                           // calculated height

            var player = new MPMoviePlayerController(NSUrl.CreateFileUrl(new [] { NSBundle.MainBundle.PathForResource("Totes", "mp4") }))
            {
                ShouldAutoplay = false,
            };
            
            player.PrepareToPlay();           

            var view = new UIView(new RectangleF(0, 0, w, h));

            player.View.Frame = view.Bounds; 
            view.AddSubview(player.View);

            SetNativeControl(view);
        }
    }
}

