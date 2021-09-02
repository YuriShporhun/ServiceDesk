using ServiceDesk.UI.ViewModels;
using ServiceDesk.UI.Views;
using System.Windows;

namespace ServiceDesk.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainViewModel mainViewModel = new();
            MainWindow mainWindow = new(mainViewModel);
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
