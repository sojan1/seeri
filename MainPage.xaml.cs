using Microsoft.Maui.Controls.PlatformConfiguration;
using seeri.Models;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
namespace seeri
{
    public partial class MainPage : ContentPage
    {
 
        private readonly DataService dataService = new DataService();
        int count = 0;
        public ObservableCollection<News> NewsItems { get; set; }
        public List<News> newsList = new List<News>();
        public MainPage()
        {
            InitializeComponent();
            //LoadNews();
            BindingContext = this;

            // Initialize the collection
            NewsItems = new ObservableCollection<News>();

            // Load data from API
            LoadNews();
        }

 
        private async void LoadNews()
        {
            string apiUrl = "https://script.google.com/macros/s/AKfycbwYytrubigugtBlXvoaOLE_8sU-7gtCDlH4j2PAdIQuwEdPXTFpe5tt0v6p3VLvcCQt/exec"; // Replace with your API URL
            newsList = await dataService.GetNewsFromApi(apiUrl);
            newsListView.ItemsSource = newsList;
        }


 
        private void OnCloseClicked(object sender, EventArgs e)
        {
           // this.ShowPopup(new PopupPage());
        }

        private async void OnListItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = ((ListView)sender).SelectedItem as News;

            if (selectedItem != null)
            {
                // this.ShowPopup(new PopupPage(selectedItem.Description));

                string str = "An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.An institution of the Syro Malankara Catholic Church, established in 1985 at Kottayam, Kerala, India, promotes Syriac studies. It is an ecumenical Institute unique in India. Its students and teachers come from not only the 7 Churches of Syriac tradition but also from other Churches from abroad.";
                
                this.ShowPopup(new PopupPage(str));
                //await DisplayAlert("Item Selected", $"Title: {selectedItem.Title}\nPublish Date: {selectedItem.PublishDate}\nDescription: {selectedItem.Description}", "OK");
            }
        }


    }



}
//private void OnItemTapped(object sender, ItemTappedEventArgs e)
//{
//    //    var popup = new PopupPage();

//    //    this.ShowPopup(popup);

//    //if (e.Item is News tappedItem)
//    //{
//    //    //descriptionLabel.Text = tappedItem.Description;
//    //    //descriptionLabel.IsVisible = true;
//    //}
//}