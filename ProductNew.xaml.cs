using seeri.ViewModels;
namespace seeri;


public partial class ProductNew : ContentPage
{
    private readonly ProductsViewModel _viewModel;

    public ProductNew(ProductsViewModel viewModel)
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

