using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class UserProfileViewModel : INotifyPropertyChanged
    {
        public UserProfileViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
