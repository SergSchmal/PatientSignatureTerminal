using System.Windows.Controls;
using PatientSignatureTerminal.ViewModel;
using Unity.Attributes;

namespace PatientSignatureTerminal.Views
{
    /// <summary>
    /// Interaction logic for ContinueMessageView
    /// </summary>
    public partial class ContinueMessageView : UserControl
    {
        public ContinueMessageView()
        {
            InitializeComponent();
        }

        [Dependency]
        public ContinueMessageViewModel ViewModel
        {
            set { DataContext = value; }
        }
    }
}
