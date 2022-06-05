using System.Diagnostics;

namespace MauiDesignMode
{
    public class CodeBehindMainPage : ContentPage
    {
        public CodeBehindMainPage()
        {
            var label = new Label { Text = "Entry - I'm displaying" };
            var grid = new Grid() { Margin = 10};
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.Add(label,0,0);
            Content = grid;

            Trace.WriteLine($"==============> CodeBehind: {DesignMode.IsDesignModeEnabled}");
        }
    }
}
