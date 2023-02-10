using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiSampleExpander.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public AsyncRelayCommand AddItemCommand { get; set; }
        private ObservableCollection<Item> _mItems;
        private int _index = 1;

        public ObservableCollection<Item> Items
        {
            get => _mItems;
            set => SetProperty(ref _mItems, value);
        }

        public MainViewModel()
        {
            AddItemCommand = new AsyncRelayCommand(AddItem);
            _mItems = new ObservableCollection<Item>();
            var items = InitializeCollection();

            foreach (var item in items)
            {
                _mItems.Add(item);
            }
        }

        private ObservableCollection<Item> InitializeCollection()
        {
            var collection = new ObservableCollection<Item>();
            for (var i = 0; i < 10; i++)
                collection.Add(new Item { Label = $"Label {i}" });
            return collection;
        }

        private Task AddItem()
        {
            _mItems.Add(new Item { Label = $"New {_index}" });
            _index++;
            return Task.CompletedTask;
        }
    }
}