using Microsoft.Maui.Controls.PlatformConfiguration;
using seeri.Models;
using CommunityToolkit.Maui.Views;
namespace seeri
{
    public partial class MainPage : ContentPage
    {
        private readonly DataService dataService = new DataService();
        int count = 0;

        public MainPage()
        {
            InitializeComponent(); 
            LoadNews();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
        private async void LoadNews()
        {
            string apiUrl = "https://script.google.com/macros/s/AKfycbwYytrubigugtBlXvoaOLE_8sU-7gtCDlH4j2PAdIQuwEdPXTFpe5tt0v6p3VLvcCQt/exec"; // Replace with your API URL
            var newsList = await dataService.GetNewsFromApi(apiUrl);
            newsListView.ItemsSource = newsList;
        }
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
        //    var popup = new PopupPage();

        //    this.ShowPopup(popup);

            //if (e.Item is News tappedItem)
            //{
            //    //descriptionLabel.Text = tappedItem.Description;
            //    //descriptionLabel.IsVisible = true;
            //}
        }
 
    }



}
 