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
    public partial class ListAccountPage : ContentPage
    {
        public ListAccountPage()
        {
            InitializeComponent();
            CustomListView.ItemsSource = new String[10];
        }
    }
}