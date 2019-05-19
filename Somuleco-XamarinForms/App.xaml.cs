using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SharedDotNetLibrary.DAOs;
using System.IO;

namespace Somuleco_XamarinForms
{
    public partial class App : Application
    {

        static UserDAO userDatabase;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static UserDAO UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDAO(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "User.db3"));
                }
                return userDatabase;
            }
        }

    }
}
