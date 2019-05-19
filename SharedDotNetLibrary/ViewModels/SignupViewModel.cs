using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class SignupViewModel : INotifyPropertyChanged
    {
        public SignupViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
