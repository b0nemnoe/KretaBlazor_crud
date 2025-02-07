using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.SchoolGrades
{
    public partial class TeachedClassesGradesViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string _title = "Tanított osztályok jegyei";
    }
}
