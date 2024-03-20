using seeri.ViewModels;

namespace seeri
{
    public partial class VerticalListPage : ContentPage
    {
        int count = 0;

        public VerticalListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }

}
