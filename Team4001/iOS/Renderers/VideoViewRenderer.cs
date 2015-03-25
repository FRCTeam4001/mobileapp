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

            var maxWidth = (float)(UIScreen.MainScreen.Bounds.Width) - 25.0f;

            var video = (VideoView)e.NewElement;    

            var a = video.Height / video.Width;     // height / width
            var w = maxWidth * WIDTH_PERCENTAGE;    // desired widths
            var h = w * a;                          // calculated height                           

            Console.WriteLine(video.Filename);

            var file = video.Filename.Split(new [] { '.' });

            if (file.Length > 2)
                throw new Exception(); // TODO
            
            var p = NSBundle.MainBundle.PathForResource(file[0], file[1]);
            Console.WriteLine(p);

            var player = new MPMoviePlayerController(NSUrl.CreateFileUrl(new [] { NSBundle.MainBundle.PathForResource(file[0], file[1]) }))
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

