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
    using ObjCRuntime;
    using AVFoundation;
    using CoreMedia;

    using Xamarin.Forms.Platform.iOS;

    public class VideoViewRenderer : ViewRenderer
    {
        private const float WIDTH_PERCENTAGE = 0.9f;

        private AVPlayer player; 
        private AVPlayerLayer playerLayer; 
        private AVAsset asset; 
        private AVPlayerItem playerItem; 

        private bool playing; 

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            var maxWidth = (float)(UIScreen.MainScreen.Bounds.Width) - 25.0f;

            var video = (VideoView)e.NewElement;    

            var a = video.Height / video.Width;     // height / width
            var w = maxWidth * WIDTH_PERCENTAGE;    // desired width
            var h = w * a;                          // computed height

            var view = new UIView(new RectangleF(0, 0, w, h));

            asset = AVAsset.FromUrl(NSUrl.FromFilename(video.Filename));
            playerItem = new AVPlayerItem(asset); 
            player = new AVPlayer(playerItem); 
            playerLayer = AVPlayerLayer.FromPlayer(player); 
            playerLayer.Frame = view.Frame; 
            view.Layer.AddSublayer(playerLayer); 

            var tapGestureRecognizer = new UITapGestureRecognizer((obj) =>
            {
                if (player != null)
                {
                    if (playing)
                    {
                        player.Pause(); 
                        playing = false; 
                    }
                    else
                    {
                        player.Play(); 
                        playing = true; 
                    }
                }
            }); 

            NSNotificationCenter.DefaultCenter.AddObserver(this, new Selector("playerItemDidPlayToEnd:"), AVPlayerItem.DidPlayToEndTimeNotification, playerItem);

            view.AddGestureRecognizer(tapGestureRecognizer); 

            SetNativeControl(view);
        }

        [Export("playerItemDidPlayToEnd:")]
        public void PlaybackEnded(NSNotification n)
        {
            if (playerItem != null)
            {
                playerItem.Seek(CMTime.Zero); 
                playing = false; 
            }
        }
    }
}

