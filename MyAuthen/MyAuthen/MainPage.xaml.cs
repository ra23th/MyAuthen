using MyAuthen.Helpers;
using MyAuthen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyAuthen
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private DatabaseAdapter DatabaseAdapter { get; }

        //private DatabaseAdapter = new DatabaseAdapter();
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            UsernameEntry.Text = Seting.UserName;
            PasswordEntry.Text = Seting.Password;

            DatabaseAdapter = new DatabaseAdapter(App.DatabasPath);
            //var data = new DatabaseAdapter(App.DatabasPath).GetUsers();
        }
        public void Login_clicked(object sender,EventArgs args)
        {
            String UserName = UsernameEntry.Text;
            String Password = PasswordEntry.Text;

            var result = DatabaseAdapter.GetUser(UserName);
            if(result == null)
            {
                //incert case
                var count = DatabaseAdapter.AddUser(new User(UserName,Password));
                DisplayAlert("title", $"insert:{count}", "close");
            }
            else if (result.Password == Password)
            {
                //success case
                Seting.UserName = UserName;
                Seting.Password = Password;
                DisplayAlert("title", $"login:{UserName},{ Password}", "close");

            }
            else
            {
                var count = DatabaseAdapter.EditUser(new User(UserName, Password));
                DisplayAlert("title", $"edit: {count}", "close");
                //update case
            }

        }
        public void Delete_clicked(object sender, EventArgs args)
        {
            DatabaseAdapter.DeleteUser();
            DisplayAlert("title", "delete", "close");
        }
        public void List_clicked(object sender, EventArgs args)
        {
            var result = DatabaseAdapter.GetUsers();
            Navigation.PushAsync(new ListAccountPage(result));
            //DisplayAlert("title", "list", "close");
        }
    }
}
