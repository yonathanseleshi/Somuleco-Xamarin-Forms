using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged 
    {
        public LoginViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
