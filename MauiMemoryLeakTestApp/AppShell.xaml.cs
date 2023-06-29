namespace MauiMemoryLeakTestApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Initialize();
	}

	private void Initialize()
	{
		FlyoutItem flyoutItem = new FlyoutItem();
		flyoutItem.Title = "SecondaryPage";

		ShellContent shellContent = new ShellContent();
		shellContent.Content = new SecondaryPage();
		shellContent.Route = $"{nameof(SecondaryPage)}_test";

		flyoutItem.Items.Add(shellContent);

		this.Items.Add(flyoutItem);
	}
}
