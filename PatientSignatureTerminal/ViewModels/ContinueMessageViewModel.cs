using System;
using PatientSignatureTerminal.Helpers;
using PatientSignatureTerminal.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace PatientSignatureTerminal.ViewModels
{
    public class ContinueMessageViewModel : BindableBase, INavigationAware
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;

        private DelegateCommand _continueCommand;

        public ContinueMessageViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
        }

        public DelegateCommand ContinueCommand =>
            _continueCommand ?? (_continueCommand = new DelegateCommand(Continue));

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if ((EWizardSteps) navigationContext.Parameters["step"] == EWizardSteps.Start)
                GetStartView();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        private void GetStartView()
        {
            Message1 = "Sehr geehrte Damen und Herren,";
            Message2 = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                       "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, " +
                       "consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum." +
                       Environment.NewLine + Environment.NewLine +
                       "Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent " +
                       "luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat." +
                       Environment.NewLine + Environment.NewLine + "VielenDank! " + Environment.NewLine + Environment.NewLine + " xxx";
            CancelButtonVisible = false;
            ContinueButtonVisible = true;
        }

        private void Continue()
        {
            _regionManager.RequestNavigate(RegionNames.MainRegion, typeof(ViewB).Name);

        }


        #region Properties

        private string _message1;

        public string Message1
        {
            get => _message1;
            set => SetProperty(ref _message1, value);
        }

        private string _message2;

        public string Message2
        {
            get => _message2;
            set => SetProperty(ref _message2, value);
        }

        private bool _cancelButtonVisible;

        public bool CancelButtonVisible
        {
            get => _cancelButtonVisible;
            set => SetProperty(ref _cancelButtonVisible, value);
        }

        private bool _continueButtonVisible;

        public bool ContinueButtonVisible
        {
            get => _continueButtonVisible;
            set => SetProperty(ref _continueButtonVisible, value);
        }

        #endregion
    }
}