using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SomulecoXamarinForms;



namespace Somuleco_XamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Unauthenticated_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UnauthenticatedTabsPage());
        }

        void Authenticated_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AuthenticatedPage());
        }

        void Authentication_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}
