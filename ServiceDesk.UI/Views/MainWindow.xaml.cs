using ServiceDesk.UI.ViewModels;
using System.Windows;

namespace Views.SeviceDesk.UI
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
