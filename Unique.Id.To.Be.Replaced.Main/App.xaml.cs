using System;
using System.Runtime.Versioning;
using System.Windows;
using Autofac;
using Unique.Id.To.Be.Replaced.Core;
using Unique.Id.To.Be.Replaced.Core.Logic.Application;
using Unique.Id.To.Be.Replaced.UI.Interfaces;
using Unique.Id.To.Be.Replaced.UI.WindowResources.MainWindow;

namespace Unique.Id.To.Be.Replaced.Main;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
[SupportedOSPlatform("Windows7.0")]
public partial class App
{
    private readonly DiContainerBuilder _mainBuilder = new ();
    private ILifetimeScope? _scope;
    private MainWindow? _mainWindow;

    /// <summary>
    /// Overridden OnStartup, this is our composition root and has the most basic work going on to start the app
    /// </summary>
    /// <param name="e">Startup event args</param>
    [SupportedOSPlatform("Windows7.0")]
    protected override void OnStartup(StartupEventArgs e)
    {
        var dependencyContainer = _mainBuilder.GetBuiltContainer();
            
        _scope = dependencyContainer.BeginLifetimeScope();
            
        var exceptionHandler = _scope.Resolve<ExceptionHandler>(); 
            
        exceptionHandler.SetupExceptionHandlingEvents();

// TO DELETE THE EXCEPTION THROW ONCE YOU HAVE SET THE FOLLOWING - START DELETING AT THIS LINE 
        const string throwMessage =
            @"Please go into App.xaml.cs and:

            1. Choose if you would like your application to run as a Notification Tray Icon Application or a normal windowed application.

            2. Set the application name.

            3. Remove this exception throw once you have done the above.";
        
        throw new NotImplementedException(throwMessage);
// TO DELETE THE EXCEPTION THROW ONCE YOU HAVE SET THE FOLLOWING - FINISH DELETING AT THIS LINE

// ReSharper disable once HeuristicUnreachableCode
#pragma warning disable CS0162 
        
        // SET THESE TWO LINES
        // BEFORE RUNNING THE APPLICATION FOR THE FIRST TIME:
        
        const bool runAsTrayIconApplication = true;
        
        ApplicationInformation.ApplicationFriendlyName = "Unique.Id.To.Be.Replaced"; 
        
        // AND THEN DELETE THE THROW LINE ABOVE...
        
        if (runAsTrayIconApplication)
        {
            // Start TrayIcon
            var unused = _scope.Resolve<ITrayIcon>();
        }
        else
        {
            // MainWindow and ViewModel setup
            _mainWindow = _scope.Resolve<MainWindow>();
            var mainWindowViewModel = _scope.Resolve<MainWindowViewModel>();
            _mainWindow.DataContext = mainWindowViewModel;
            
            _mainWindow.Show();    
        }
#pragma warning restore CS0162
    }
}