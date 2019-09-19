using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyAuthen.Droid.Services;
using MyAuthen.Services;

[assembly: Xamarin.Forms.Dependency(typeof(YoutubeService))]

namespace MyAuthen.Droid.Services
{
    public class YoutubeService : IYoutubeService
    {
        public void PlayYoutube(string idYoutube)
        {
            Context context = Android.App.Application.Context;

            // deep link
            var uri = Android.Net.Uri.Parse("https://www.youtube.com/watch?v=" + idYoutube);
            var intent = new Intent(Intent.ActionView, uri);
            intent.AddFlags(ActivityFlags.NewTask);
            context.StartActivity(intent);

            Toast.MakeText(context, "Open Youtube", ToastLength.Long).Show();
        }
    }
}