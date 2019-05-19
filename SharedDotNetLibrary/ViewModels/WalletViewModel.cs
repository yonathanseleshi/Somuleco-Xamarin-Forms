using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class WalletViewModel : INotifyPropertyChanged
    {
        public WalletViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
