using PatientSignatureTerminal.Helpers;
using PatientSignatureTerminal.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PatientSignatureTerminal
{
    public class PatientSignatureTerminalModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public PatientSignatureTerminalModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ContinueMessage>();
            containerRegistry.RegisterForNavigation<ViewB>();
            containerRegistry.RegisterForNavigation<ViewA>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.MainRegion, typeof(ContinueMessage).Name, new NavigationParameters{{"step", EWizardSteps.Start}});
        }
    }
}