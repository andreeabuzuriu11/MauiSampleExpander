using MauiSampleExpander.ViewModels;

namespace MauiSampleExpander.Pages;

public abstract class BaseAppPage<T> : ContentPage where T : BaseViewModel
{
    protected T ViewModel => BindingContext as T;

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel?.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        ViewModel?.OnDisappearing();
    }

    protected override bool OnBackButtonPressed()
    {
        var viewModelHandledBackButton = ViewModel.OnBackButtonPressed();

        if (viewModelHandledBackButton) return true;
        return base.OnBackButtonPressed();
    }
}