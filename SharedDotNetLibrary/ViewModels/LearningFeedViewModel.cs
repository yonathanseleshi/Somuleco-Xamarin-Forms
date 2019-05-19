using System;
using Xamarin.Forms;
using System.ComponentModel;


namespace SharedDotNetLibrary.ViewModels
{
    public class LearningFeedViewModel : INotifyPropertyChanged
    {
        public LearningFeedViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
