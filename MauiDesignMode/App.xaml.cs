namespace MauiDesignMode;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new StartupPageTabbed();
	}
}
