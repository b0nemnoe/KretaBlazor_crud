using Kreta.Shared.Models.SchoolCitizens;
using Kreta.ViewModel.Base;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public interface IStudentViewModelBase: IBaseViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
    }
}
