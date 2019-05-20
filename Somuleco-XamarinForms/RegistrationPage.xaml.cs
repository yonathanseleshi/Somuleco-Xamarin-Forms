using System;
using System.Collections.Generic;
using SharedDotNetLibrary.ViewModels;

using Xamarin.Forms;

namespace SomulecoXamarinForms
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {

            var vm = new SignupViewModel();
            this.BindingContext = vm;


            InitializeComponent();
        }




        void Cancel()
        {

            Navigation.PopAsync();
        }
    }
}
