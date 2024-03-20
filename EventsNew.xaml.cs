using seeri.ViewModels;
namespace seeri;


public partial class EventsNew : ContentPage
{
    private readonly EventsViewModel _viewModel;

    public EventsNew(EventsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadProductsAsync();
    }
}

