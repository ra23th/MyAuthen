using MyAuthen.Models;
using MyAuthen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAuthen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JsonPage : ContentPage
    {
        public JsonPage()
        {
            InitializeComponent();

            // lamda
            Task.Run(async() =>
            {
                // backgroudbthread
                var resual = await NetworkService.GetData(new User("admin", "password"));
            }
                );

            
        }
    }
}