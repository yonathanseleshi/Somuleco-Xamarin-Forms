using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class SocialFeedViewModel : INotifyPropertyChanged
    {
        public SocialFeedViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
