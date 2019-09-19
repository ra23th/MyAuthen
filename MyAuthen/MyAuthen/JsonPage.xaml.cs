using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyAuthen.Helpers;
using MyAuthen.Models;
using MyAuthen.Services;
using Xamarin.Forms;

namespace MyAuthen
{
    public partial class JsonPage : ContentPage
    {
        public JsonPage()
        {
            InitializeComponent();

            FeddData();
            /*
            CustomListView.ItemsSource = new String[100];

            // lamda
            Task.Run(async () => {
                // background thread
                var result = await NetworkService.GetData(new User("admin", "password"));
            });*/

        }

        private void FeddData()
        {
            Task.Run(async () => {
                //backgroud thead
                var username = Seting.UserName;
                var password = Seting.Password;

                var user = new User(username, password);

                var result = await NetworkService.GetData(user);

                Device.BeginInvokeOnMainThread(() => { 
                //main thead

                if(result != null)
                {
                    JsonListView.ItemsSource = result.youtubes; //alay
                }
                else
                {
                    //to do
                }

                    Loading.IsRunning = false;
                });


            });
            }

        private void OpenYoutube(Object sender,ItemTappedEventArgs events)
        {
            //de-select
            JsonListView.SelectedItem = false;

            var item = events.Item as Youtube;

            //Dependency Service
            DependencyService.Get<IYoutubeService>().PlayYoutube(item.id);
        }
    }

}
