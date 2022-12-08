using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSampleExpander.ViewModels
{
    public abstract class BaseViewModel : ObservableObject
    {

        protected BaseViewModel()
        { }


        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {

        }

        public virtual bool OnBackButtonPressed()
        {
            return false;
        }
    }
}

