using Prism.Regions;

namespace PatientSignatureTerminal.ViewModels
{
    public class ViewBViewModel : INavigationAware
    {
        public ViewBViewModel()
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new System.NotImplementedException();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}