namespace Samurai;

using Autofac;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Glitonea.Extensibility;
using PropertyChanged;
using Samurai.Windows;

[DoNotNotify]
public partial class App : Application, IContainerBuildingSubscriber
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }

    public void OnBuildingIoC(ContainerBuilder containerBuilder)
    {
    }
}