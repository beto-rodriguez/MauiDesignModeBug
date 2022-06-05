namespace MauiDesignMode
{
    internal class StartupPageTabbed : TabbedPage
    {
        public StartupPageTabbed()
        {
            Children.Add(new AppShell() { Title = "Shell"});
            Children.Add(new CodeBehindMainPage() { Title = "NoShell" });
        }
    }
}
