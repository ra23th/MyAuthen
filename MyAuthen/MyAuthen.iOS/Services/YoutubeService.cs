using System;
using Foundation;
using MyAuthen.iOS.Services;
using MyAuthen.Services;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(YoutubeService))]
namespace MyAuthen.iOS.Services
{
    public class YoutubeService : IYoutubeService
    {
        public void PlayYoutube(string idYoutube)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl("https://www.youtube.com/watch?v=" + idYoutube));
        }
    }
}