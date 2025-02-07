using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.SchoolGrades
{
    public partial class EndOfYearGradesViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _title = "Év végi jegyek";
    }
}
