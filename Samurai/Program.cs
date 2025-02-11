namespace Samurai;

using System;
using System.Reflection;
using Avalonia;
using Glitonea;

internal class Program
{
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .UseGlitoneaFramework(Assembly.GetExecutingAssembly())
            .WithInterFont()
            .LogToTrace();
}