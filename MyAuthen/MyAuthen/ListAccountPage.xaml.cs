using System;
using System.Collections.Generic;
using MyAuthen.Models;
using Xamarin.Forms;

namespace MyAuthen
{
    public partial class ListAccountPage : ContentPage
    {


        public ListAccountPage(List<User> result)
        {
            InitializeComponent();

            Title = "List Account";

            // Dummy
            //CustomListView.ItemsSource = new String[10];

            CustomListView.ItemsSource = result;
        }

        public void ListViewTapped(object sender, ItemTappedEventArgs events)
        {
            // de-select item
            CustomListView.SelectedItem = null;
        }






    }
}
