using System.Windows;
using PatientSignatureTerminal.Helpers;
using Prism.Regions;

namespace PatientSignatureTerminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            var navigationParameters = new NavigationParameters { { "step", EWizardSteps.Start } };
            regionManager.RequestNavigate("MainRegion", "ContinueMessageView", navigationParameters);

        }
    }
}
