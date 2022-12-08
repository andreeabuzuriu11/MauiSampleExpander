using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSampleExpander
{
    public class HeaderItem : ObservableObject
    {
        private string mTitle;

        public string Title
        {
            get => mTitle;
            set => SetProperty(ref mTitle, value);
        }
    }
}

