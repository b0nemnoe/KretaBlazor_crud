using Kreta.Shared.Models;
using Kreta.ViewModel.Base;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public interface ITypeOfEducationViewModel : IBaseViewModel
    {
        public ObservableCollection<TypeOfEducation> TypeOfEducations { get; set; }

    }
}
