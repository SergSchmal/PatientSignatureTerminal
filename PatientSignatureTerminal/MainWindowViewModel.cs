using System;
using PatientSignatureTerminal.Helpers;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace PatientSignatureTerminal
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            eventAggregator.GetEvent<MainViewNoteEvent>().Subscribe(SetNoteText);
            NoteText = "Hinweis: Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, " +
                       Environment.NewLine + "vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit.";
        }

        private void SetNoteText(string note)
        {
            NoteText = note;
        }

        private string _noteText;
        public string NoteText
        {
            get { return _noteText; }
            set { SetProperty(ref _noteText, value); }
        }
        public Action CloseAction { get; set; }

        private DelegateCommand _shutdownDialogCommand;
        public DelegateCommand ShutdownDialogCommand =>
            _shutdownDialogCommand ?? (_shutdownDialogCommand = new DelegateCommand(ShutdownDialog));

        void ShutdownDialog()
        {
            CloseAction();
        }
    }
}