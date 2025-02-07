using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.SchoolGrades
{
    public partial class HalfOfYearGradesViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _title = "Félévi jegyek zárása";
    }
}
