namespace Samurai.UI;

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

public class SamuraiUI : ResourceDictionary
{
    public SamuraiUI()
    {
        AvaloniaXamlLoader.Load(this);
    }
}