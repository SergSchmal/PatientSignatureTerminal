using PatientSignatureTerminal.Helpers;
using PatientSignatureTerminal.ViewModel;
using PatientSignatureTerminal.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PatientSignatureTerminal
{
    public class PatientSignatureTerminalModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", typeof(ContinueMessageView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ContinueMessageViewModel>();
            containerRegistry.RegisterForNavigation<NewView>();
        }

    }
}