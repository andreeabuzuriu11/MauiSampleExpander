using System;
using System.Collections.ObjectModel;

namespace MauiSampleExpander.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<HeaderItem> mExpandableHeaders;

        public ObservableCollection<HeaderItem> ExpandableHeaders
        {
            get => mExpandableHeaders;
            set => SetProperty(ref mExpandableHeaders, value);
        }

        public MainViewModel()
        {
            mExpandableHeaders = new ObservableCollection<HeaderItem>();
            var items = InitializeCollection();

            foreach (var item in items)
            {
                mExpandableHeaders.Add(item);
            }
        }

        private ObservableCollection<HeaderItem> InitializeCollection()
        {
            var collection = new ObservableCollection<HeaderItem>();
            for (var i = 0; i < 10; i++)
                collection.Add(new HeaderItem { Title = $"Title {i}" });
            return collection;
        }
    }
}

