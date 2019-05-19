using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class CartViewModel : INotifyPropertyChanged
    {
        public CartViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
