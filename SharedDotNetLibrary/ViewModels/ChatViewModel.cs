using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        public ChatViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
