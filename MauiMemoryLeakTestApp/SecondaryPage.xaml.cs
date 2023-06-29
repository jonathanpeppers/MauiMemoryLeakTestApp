namespace MauiMemoryLeakTestApp;

public partial class SecondaryPage : ContentPage
{
	public SecondaryPage()
	{
		InitializeComponent();
	}

    private async void OpenTertiaryPageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TertiaryPage());
    }
}