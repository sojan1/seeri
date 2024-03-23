using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
namespace seeri;

public partial class PopupPage : Popup
{
	public PopupPage(string description)
	{
		InitializeComponent();
        lblDescription.Text = description;
    }

    private async void CloseButton_Clicked(object sender, EventArgs e) {
       
    }
}