using ServiceDesk.UI.ViewModels;
using System.Windows;

namespace ServiceDesk.UI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(ViewModelBase viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
