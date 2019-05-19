using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class NotificationsViewModel : INotifyPropertyChanged
    {
        public NotificationsViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
