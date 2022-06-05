using System.Diagnostics;

namespace MauiDesignMode;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent(); 
        Trace.WriteLine($"==============> Shell: {DesignMode.IsDesignModeEnabled}");
    }
}
