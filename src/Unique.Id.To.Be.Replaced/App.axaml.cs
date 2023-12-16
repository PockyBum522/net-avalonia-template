using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Unique.Id.To.Be.Replaced.ApplicationLogistics;
using Unique.Id.To.Be.Replaced.ViewModels;
using Unique.Id.To.Be.Replaced.Views;

namespace Unique.Id.To.Be.Replaced;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Dependency Injection:
        var loggerConfiguration = LoggerSetup.ConfigureLogger();

        // ReSharper disable once ConvertIfStatementToSwitchStatement because I don't know that it's actually cleaner
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(
                    loggerConfiguration)
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel(
                    loggerConfiguration)
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}