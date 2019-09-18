using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            CustomListView.ItemsSource = new String[100];

            // lamda
            Task.Run(async () => {
                // background thread
                var result = await NetworkService.GetData(new User("admin", "password"));
            });

        }
    }
}
