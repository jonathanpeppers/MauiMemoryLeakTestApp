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

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    private void GCCollectButton_Clicked(object sender, EventArgs e)
    {
        GC.Collect();
    }
}